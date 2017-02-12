using System;
using NormalAI;
using UserSpecs;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Creating new user */
            user my = new user();
            /*Saying "Hello!..." */
            ai.say("Hi, sir!");
            /*Getting his/her name*/
            ai.say("Sir, what is your name?");
            my.firstname = ai.getStr();
            if(my.firstname.Contains(" "))
            {
                ai.say("Sir, how much do you have name?");
                try
                {
                    int agenumber = Convert.ToInt32(ai.getStr());
                }
                catch (System.FormatException)
                {
                    ai.say("Please, enter with numbers!");
                }
            }
            
        }
    }
}
