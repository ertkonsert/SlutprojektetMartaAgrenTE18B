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
           

            //"Loading"
            Console.Title = "Initiating startup sequence...  Please Wait";
            /*
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

            */
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine().Trim();

            Console.WriteLine("What do you want to name your Pal?");
            string palName = Console.ReadLine().Trim();

            //Jag sätter den här frågan i en variabel så jag slipper skriva ut den mer än en gång och om jag ändrar på den ändras den överallt.
            string question = "You are about to name your Pal " + palName + "! Is that alright? (Name cannot be changed later)";
            Console.WriteLine(question);
            string answer = Console.ReadLine().Trim().ToLower();

            //Lista för jag vill kunna lägga till fler alternativ senare.
            List<string> answerYesOrNo = new List<string>() { "yes", "no" };
            answer = CheckAnswer(question, answerYesOrNo, answer);

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
                
                answer = CheckAnswer(question, answerYesOrNo, answer);
            }

            Console.WriteLine("Great! We're now ready to start!");
            Thread.Sleep(2000);
            Console.Clear();


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

            Console.Title = "Pal Place";

            Console.WriteLine("...hello?");
            Console.WriteLine(name + "?");
            Console.ReadLine();
            Console.WriteLine("Hi!");

            Console.WriteLine(name + "..." + " Such a lovely name. :>");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("Well, it is a pleasure to meet you " + name + ".");
            Console.WriteLine("It's going to be so fun to play games with you!");
            Console.WriteLine("I have three games here for you, but first;");
            Console.WriteLine("What is your birthmonth?");
            
            string birthMonthAnswer = Console.ReadLine().ToLower().Trim();
            //Lista för answerKey är en lista och jag vill inte ha krångel med att konvertera från array.
            List<string> months = new List<string>() { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
            birthMonthAnswer = CheckAnswer("What is your birthmonth?", months, birthMonthAnswer);
            //Kommer användas senare i gissa siffran, +1 för att få rätt månad eftersom listan börjar på 0.
            int birthMonth = months.IndexOf(birthMonthAnswer) + 1;

            Console.WriteLine("And what day of the month where you born on?");
            string birthDayAnswer = Console.ReadLine().ToLower().Trim();

            bool convert = int.TryParse(birthDayAnswer, out int birthDay);

            while (convert == false || birthDay > 31 || birthDay < 1)
            {
                Console.WriteLine("That's not a valid answer :(");
                Console.WriteLine("Try again, on what day where you born?");
                birthDayAnswer = Console.ReadLine().ToLower().Trim();
                convert = int.TryParse(birthDayAnswer, out birthDay);
            }
            
            question = "So you were born on " + birthDay + " " + birthMonthAnswer + "?";
            Console.WriteLine(question);
            answer = Console.ReadLine().ToLower().Trim();
            answer = CheckAnswer(question, answerYesOrNo, answer);
            
            if (answer == "no")
            {
                
            }
            
            //Fixa while loop som körs så länge answer == no och fixa så yes tar en vidare
            



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
