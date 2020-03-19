using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SlutprojektetMärtaÅgrenTE18B
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator;

            //"Loading"
            Console.Title = "Initiating startup sequence...  Please Wait";

            //for loop som kör loading "animationen" fyra gånger.
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Loading");
                //for loop som skriver ut 3 punkter
                for (int j = 0; j < 3; j++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");
                    
                }
                Thread.Sleep(1500);
                Console.Clear();
            }

            Console.WriteLine("Ready to start, press Enter to launch :)");
            Console.ReadLine();
            Console.Clear();

            Console.Title = "Welcome to Pal Place!";

            //Start och intro
            Console.WriteLine("Hello new User!");
            Console.WriteLine("And welcome to Pal Place!");
            Console.WriteLine("Pal Place is the one and only place where you get to hang out with your very own AI Pal! All for free!");
            Console.WriteLine("Your own personal Pal will learn from your interactions and adapt! For the low, low price of $0!");
            Console.WriteLine("To get you started, here are some quick and easy questions for you to answer!");
            Console.WriteLine();

            //fix this
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine().Trim();

            Console.WriteLine("What do you want to name your Pal?");
            string palName = Console.ReadLine().Trim();

            //Jag sätter den här frågan i en variabel så jag slipper skriva ut den mer än en gång och om jag ändrar på den ändras den överallt.
            string question = "You are about to name your Pal " + palName + "! Is that alright? (Name cannot be changed later)";
            Console.WriteLine(question);
            string answer = Console.ReadLine().Trim().ToLower();

            //Lista för jag vill kunna lägga till fler alternativ senare.
            List<string> answerKey = new List<string>() { "yes", "no" };
            answer = CheckAnswer(question, answerKey, answer);

            //Om man ändrar sig får man ändra namnet så mycket man vill
            while (answer == "no")
            {
                Console.WriteLine("Okay, that's fine. Picking a name is not easy, after all!");
                Console.WriteLine("What do you want to name your Pal?");
                palName = Console.ReadLine().Trim();
                //frågan behöver skrivas om för att det nya namnet man angivit ska gälla
                question = "You are about to name your Pal " + palName + "! Is that alright? (Name cannot be changed later)";
                Console.WriteLine(question);
                answer = Console.ReadLine().Trim().ToLower();
                
                answerKey = new List<string>() { "yes", "no" };
                answer = CheckAnswer(question, answerKey, answer);
            }

            Console.WriteLine("Great! We're now ready to start!");
            Thread.Sleep(2000);
            Console.Clear();

            //fix both chunk above and below

            //Pal startar
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");

                }
                Thread.Sleep(1000);
                Console.Clear();
            }

            Console.WriteLine("...hello?");
            Console.WriteLine(name + "?");
            Console.ReadLine();
            Console.WriteLine("Hi!");

            Console.WriteLine(name + "..." + " Such a lovely name. :>");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("Well, it is a pleasure to meet you " + name + ".");
            Console.WriteLine("");


            //Hub




            //Rock, Paper, Scissors


            //Hangman


            //Guess the Number







            //Ending?


            Console.ReadLine();
        }


        static string CheckAnswer (string question, List<string> answerKey, string answer)
        {

            
            while (answerKey.Contains(answer) == false)
            {
                Console.WriteLine("I'm afraid I don't understand your answer.");
                Console.WriteLine(question);
                answer = Console.ReadLine().Trim().ToLower();
            }

            return answer;

        }

        static void RPS()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");


        }

    }
}
