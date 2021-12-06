using System;
using System.Threading;
using System.Text.RegularExpressions;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Hello world! ... no, just kidding, you have come to a damn simple menu...");
            Console.WriteLine("Please choose an option and press enter: ");
            Console.WriteLine("1a) Please provide your age to get the cost of going to the movies: ");
            Console.WriteLine("1b) Are you a bunch of guys going to the movies, give me the no of guys u are and the age of yours, I´ll give ya the total price of your company: ");
            Console.WriteLine("2) Stutter 10 times of your input of whatever");
            Console.WriteLine("3) Split a sentence in words and output the third word");
            Console.WriteLine("0) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1a":
                    Cost();
                    return true;
                case "2":
                    Stutter();
                    return true;
                case "3":
                    SplitASentence();
                    return true;
                case "0":
                    return false;
                default:
                    Console.Write("Wrong choice, please try again: ");
                    Thread.Sleep(3000);
                    return true;

            }
        }
        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }
        private static string CaptureInput2()
        {
            Console.Write("Enter your sentence and I will give ya the third word: ");
            return Console.ReadLine();
        }
        private static string CaptureInput3()
        {
            Console.Write("Enter your age: ");
            return Console.ReadLine();
        }
        private static void Stutter()
        {
            Console.Clear();
            Console.WriteLine("Stutter");

            DisplayResult2(CaptureInput());
        }

        private static void SplitASentence()
        {
            Console.Clear();
            Console.WriteLine("Split a sentence in words");
            string phrase = CaptureInput2();
            // fixar till mellanslaget mellan orden om användaren trycker in ngt annat än mellanslag
            phrase = Regex.Replace(phrase, @"\s+", " ");
            // delat upp meningen i ord med mellanslag som separator
            string[] words = phrase.Split(' ');

            Console.WriteLine(words[2]);


            Thread.Sleep(4000);
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();

        }
        private static void Cost()
        {
            Console.Clear();
            Console.WriteLine("Cost of your movie ticket: ");

            string age = CaptureInput3();

            int iage = Int32.Parse(age);
            Console.WriteLine("Your age" + iage);

            if (iage < 65)
            {
                if (iage < 19)
                    Console.WriteLine("youth price 80 SEK");
                if (iage > 18)
                    Console.WriteLine("normal price 120 SEK");
            }

            else
            {
                Console.WriteLine("retiree price 90 SEK");
            }

            Thread.Sleep(4000);
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();

        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
        private static void DisplayResult2(string message)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i}.{message}, ");
            }


            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}