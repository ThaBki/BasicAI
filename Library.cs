using System;

namespace NormalAI
{
    public static class ai
    {
        public static void say(string a)
        {
            Console.WriteLine(a);
        }
        public static DateTime getDate()
        {
            DateTime a = DateTime.Now;
            return a;
        }
        public static string getStr()
        {
            string a = Console.ReadLine();
            return a;
        }
        
    }
}