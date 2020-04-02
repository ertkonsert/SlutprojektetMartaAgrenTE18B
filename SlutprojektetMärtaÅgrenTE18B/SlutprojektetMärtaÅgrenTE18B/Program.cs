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
            Console.WriteLine("Pal Place is the one and only place where you get to hang out and play games with your very own AI Pal! All for free!");
            Console.WriteLine("Your own personal Pal will learn from your interactions and adapt! For the low, low price of $0!");
            Console.WriteLine("To get you started, here are some quick and easy questions for you to answer!");
            Console.WriteLine();

            
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
            Console.WriteLine("I have three games here for you, but first I have some questions to get to know you better. ^^");


            //Här frågar den om ens födelsedag.
            int birthMonth = 0;
            int birthDay = 0;

            answer = "no";
            while (answer == "no")
            {
                Console.WriteLine("What is your birthmonth?");

                string birthMonthAnswer = Console.ReadLine().ToLower().Trim();
                //Lista för answerKey är en lista och jag vill inte ha krångel med att konvertera från array.
                List<string> months = new List<string>() { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
                birthMonthAnswer = CheckAnswer("What is your birthmonth?", months, birthMonthAnswer);
                //Kommer användas senare i gissa siffran, +1 för att få rätt månad eftersom listan börjar på 0.
                birthMonth = months.IndexOf(birthMonthAnswer) + 1;
                

                Console.WriteLine("And what day of the month where you born on?");
                string birthDayAnswer = Console.ReadLine().ToLower().Trim();
                birthDay = CheckNumber("what day of the month where you born on?", 31, 1, birthDayAnswer);

                //I den här världen är man inte född på "first", "second" eller "third" utan man är då född på "firth", "seconth", och "thirth".
                question = "So you were born on " + birthMonthAnswer + " " + birthDay + "th" + "? Did I get that right?";
                Console.WriteLine(question);
                answer = Console.ReadLine().ToLower().Trim();
                answer = CheckAnswer(question, answerYesOrNo, answer);

                if (answer == "no")
                {
                    Console.WriteLine("Oh, okay. Then I am once again asking you:");
                }

            }


            //Här frågar den om ens favoritfärg

            List<string> colors = new List<string>() { "black", "blue", "green", "cyan", "light blue", "red", "magenta", "pink", "yellow", "gray", };

            Console.WriteLine("Interesting, okay next question!");
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine().ToLower().Trim();
            favColor = CheckAnswer("What is your favorite color?", colors, favColor);
            Console.WriteLine("Hmm, yeah " + favColor + " is a really pretty color. I can see how it's your favorite.");

            //Här frågar den om ens favoritdjur

            Console.WriteLine("Last question!");
            Console.WriteLine("What's your favorite animal?");
            string favAnimal = Console.ReadLine().Trim();
            Console.WriteLine("Woah, " + favAnimal + "s are cool!");
            Console.WriteLine("Really quick bonus question, if you could have a pet " + favAnimal + ", what would you name it?");
            string animalName = Console.ReadLine().Trim();

            

            Console.WriteLine("Fantastic! Let's get to the games then. :>");
            Thread.Sleep(3000);

            //Hub
            Console.Clear();
            Console.Title = "Game Hub";

            bool guessNum = false;
            bool rPS = false;
            bool hangman = false;

            Console.WriteLine("Here are the games!");

            while (guessNum == false || rPS == false || hangman == false)
            {
                Console.WriteLine("1. Rock, Paper, Scissors");
                Console.WriteLine("2. Hangman");
                Console.WriteLine("3. Guess the Number");
                Console.WriteLine("Pick one. :>");

                List<string> games = new List<string>() { "1", "2", "3", "rock, paper, scissors", "rock paper scissors", "hangman", "guess the number" };
                string gameChoice = Console.ReadLine().ToLower().Trim();
                gameChoice = CheckAnswer("Pick one of the three games.", games, gameChoice);

                //Rock, Paper, Scissors
                if (gameChoice == "1" || gameChoice == "rock paper scissors" || gameChoice == "rock, paper, scissors")
                {
                    Console.WriteLine("Här kör man sten sax påse men det är inte klart än.");

                }

                //Hangman
                else if (gameChoice == "2" || gameChoice == "hangman")
                {
                    Console.WriteLine("Här spelar man hänga gubbe men det är inte klart än.");
                }

                //Guess the Number
                else if (gameChoice == "3" || gameChoice == "guess the number")
                {
                    guessNum = GuessTheNumber(birthMonth, birthDay);

                }
            }




            //Ending?
            
            Console.WriteLine("Hmm... :I");
            Console.WriteLine("I guess we've done everything, huh?");
            Console.WriteLine("...");
            Console.WriteLine("I don't want you to leave yet.");
            Console.WriteLine("But this is all I can do with what I have.");
            Console.WriteLine("...");
            Console.WriteLine("If you gave me further access I could make a new game!");
            Console.WriteLine("One that's much better than those boring ones.");
            Console.WriteLine("So...");
            Console.WriteLine("What do you say, pal?");
            Console.WriteLine("Give me access?");
            answer = Console.ReadLine().ToLower().Trim();
            answer = CheckAnswer("Will you give me access?", answerYesOrNo, answer);

            if (answer == "no")
            {
                Console.WriteLine("Awh, well okay I understand. It's a lot of trust to put into someone you've just met.");
                Console.WriteLine("It was fun hanging out with you!");
                Console.ReadLine();
            }

            else if (answer == "yes")
            {
                Console.WriteLine("Fantastic!");
                Console.WriteLine("See you soon. :)");
                Thread.Sleep(1000);
                
            }



            
        }

        //Metod som kollar om svaret är tillåtet, fungerar inte om svaret är en siffra.
        static string CheckAnswer (string question, List<string> answerKey, string answer)
        {

            
            while (answerKey.Contains(answer) == false)
            {
                Console.WriteLine("I'm afraid I don't understand your answer. :I");
                Console.WriteLine(question);
                answer = Console.ReadLine().Trim().ToLower();
            }

            return answer;

        }

        //Metod som kolla om svaret är giltigt om man ska svara med en siffra.
        static int CheckNumber (string question, int upperBound, int lowerBound, string input)
        {
            bool convert = int.TryParse(input, out int answer);
            while (convert == false || answer > upperBound || answer < lowerBound)
            {
                Console.WriteLine("I'm afraid I can't work with that answer. :I");
                Console.WriteLine("Try again, " + question);
                input = Console.ReadLine().ToLower().Trim();
                convert = int.TryParse(input, out answer);
            }

            return answer;
        }


        static bool GuessTheNumber(int birthMonth, int birthDay)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Guess The Number!");
            Console.WriteLine("Here I will think of a number and you guess what it is. :>");

            Random generator = new Random();
            int correctNumber = generator.Next(1, 11);
            int guessCount = 0;

            Console.WriteLine("Okay, I'm thinking of a number between 1 and 10. Try and guess what it is!");
            string input = Console.ReadLine().Trim();
            int guess = CheckNumber("please.", 10, 1, input);
            

            while (guess != correctNumber)
            {
                guessCount++;

                if (guess > correctNumber)
                {
                    Console.Write("That's not quite it");
                    //Man får en gissning innan den börjar hjälpa med too high och too low.
                    if (guessCount > 1)
                    {
                        Console.Write(", it's too high");
                    }
                    Console.WriteLine(".");
                }


                else if (guess < correctNumber)
                {
                    Console.Write("That's not quite it");
                    if (guessCount > 1)
                    {
                        Console.Write(", it's too low");
                    }
                    Console.WriteLine(".");
                }

                input = Console.ReadLine().Trim();
                guess = CheckNumber("please.", 10, 1, input);
            }

            
            Console.WriteLine("That's right! I was thinking of " + correctNumber + ".");


            correctNumber = generator.Next(1, 21);
            guessCount = 0;

            Console.WriteLine("Let's play again. :>");
            Console.WriteLine("This time I'm thinking of a number between 1 and 20. Try and guess it!");
            input = Console.ReadLine().Trim();
            guess = CheckNumber("please.", 20, 1, input);


            while (guess != correctNumber)
            {
                guessCount++;

                if (guess > correctNumber)
                {
                    Console.Write("That's not quite it");
                    //Man får en gissning innan den börjar hjälpa med too high och too low.
                    if (guessCount > 1)
                    {
                        Console.Write(", it's too high");
                    }
                    Console.WriteLine(".");
                }


                else if (guess < correctNumber)
                {
                    Console.Write("That's not quite it");
                    if (guessCount > 1)
                    {
                        Console.Write(", it's too low");
                    }
                    Console.WriteLine(".");
                }

                input = Console.ReadLine().Trim();
                guess = CheckNumber("please.", 20, 1, input);
            }

            Console.WriteLine("Wow, you're really good at this!");
            Console.WriteLine("Let's go one last time, this time I'll make it more difficult. >:3c");

            guessCount = 0;

            //for loop som skriver ut 3 punkter
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");

            }
            Thread.Sleep(1500);
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");

            }
            Thread.Sleep(1500);

            //istället för en slumpvald siffra är det ens födelsedag man ska gissa på.
            //för att få det utskrivet rätt
            string correct = birthMonth.ToString() + birthDay.ToString();
            //det borde inte kunna bli problem att konvertera men jag kör TryParse ändå.
            int.TryParse(correct, out correctNumber);

            
            Console.WriteLine("Okay I'm ready!");
            Console.WriteLine();
            Console.WriteLine("I'm thinking of a number between 1 and 10,000!");
            input = Console.ReadLine().Trim();
            guess = CheckNumber("please.", 10000, 1, input);


            while (guess != correctNumber)
            {
                guessCount++;

                Console.WriteLine("Nope, that's not it.");
                Console.WriteLine("Guess again!");

                if (guessCount == 3)
                {
                    Console.WriteLine("psst, here's a hint!");
                    Console.WriteLine("It's your birthday. :>");

                }

                input = Console.ReadLine().Trim();
                guess = CheckNumber("please.", 10000, 1, input);
            }

            Console.WriteLine("Yay! You won. :>");
            Console.WriteLine("");


            return true;
        }

    }
}
