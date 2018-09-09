using System;

namespace EventTest
{
    class EventPublisher
    {
        public delegate void MyEventHandler(object sender, object sender2, EventPublisherArgs e);
        public event EventHandler MyEvent;
        public event MyEventHandler MyEvent2;
        public void Do()
        {
            if (MyEvent != null)
                MyEvent(null, null);
            if (MyEvent2 != null)
            {
                EventPublisherArgs args = new EventPublisherArgs("데이터");
                MyEvent2(this, this, args);
            }
        }
    }
    class EventPublisherArgs : System.EventArgs
    {
        public string myEventData;
        public EventPublisherArgs(string myEventData)
        {
            this.myEventData = myEventData;
        }
    }
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.MyEvent += doAction;
            p.MyEvent2 += doAction;
            p.MyEvent2 += delegate (object sender, object sender2, EventPublisherArgs e)
            {
                Console.WriteLine("MyEvent2-1라는 이벤트 발생(e : {0})",e.myEventData);
            };
            p.MyEvent += (sender, e) => Console.WriteLine("MyEvent1-1라는 이벤트 발생"); 

            p.Do();
        }
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent라는 이벤트 발생");
        }
        static void doAction(object sender, object sender2, EventPublisherArgs e)
        {
            Console.WriteLine("MyEvent2라는 이벤트 발생(e : {0})", e.myEventData);
        }
    }

}
