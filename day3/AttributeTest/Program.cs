#define SOUNDCARD
#define SPEAKER

using System;
using System.Diagnostics;

namespace AttributeTest
{
    class Test
    {
        [Conditional ("SOUNDCARD")]
        static void isSound() { isSpeaker(); }

        [Conditional("SPEAKER")]
        static void isSpeaker() { Console.WriteLine("음악을 들을 수 있습니다..."); }

        static void Main(string[] args)
        {
            isSound();
        }
    }
}
