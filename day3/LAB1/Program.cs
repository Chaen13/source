using System;
using System.Collections;
using System.Collections.Generic;

namespace LAB1
{
    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가="
                    + danga + "]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get; set; }

        public override String ToString()
        {
            return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum
                    + "]";
        }
    }

    class CartTest
    {
        static void Main()
        {
            Cart cpen = new Cart();
            cpen.goods = new Goods(1001, "볼펜", 1000); 
            cpen.count = 2;
            cpen.sum = 2000;

            Cart cpensil = new Cart();
            cpensil.goods = new Goods(1002, "연필", 500);
            cpensil.count = 2;
            cpensil.sum = 1500;

            Cart cstrawberry = new Cart();
            cstrawberry.goods = new Goods(1003, "딸기", 6000);
            cstrawberry.count = 2;
            cstrawberry.sum = 12000;

            int nCartIdx = 1;
            Dictionary<int, Cart> cartList = new Dictionary<int, Cart>();
            cartList.Add(nCartIdx++, cpen);
            cartList.Add(nCartIdx++, cpensil);
            cartList.Add(nCartIdx++, cstrawberry);

            SortedList s = new SortedList(cartList);

            Console.WriteLine("CartNo\t코드\t상품명\t단가\t수량\t합계금액");
            Console.WriteLine("----------------------------------------------");
            foreach (KeyValuePair<int, Cart> d in cartList)
            {
                Console.WriteLine(d.Key + "\t{0}\t{1}\t{2}\t{3}\t{4}"
                    , ((Goods)d.Value.goods).goodsno, ((Goods)d.Value.goods).gname, ((Goods)d.Value.goods).danga
                    , d.Value.count, d.Value.sum);
            }
        }
    }
}
