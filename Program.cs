using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triangle();  // Class 1 - Print lines
            //Story();     // Class 2 - Using variables
            //TestingTypes(); // Class 3 - Different data types
            //ManipulateStrings(); // Class 4 - Manipulating strings
            //InputPhrases(); // Class 5 - Getting input from keyboard
            //Calculator(); // Class 6 - Using math operators
            //ManipArrays(); // Class 7 - numerical and text arrays
            GuessMachine();  // Class 8 - Exploring while loops

            Console.ReadLine();
        }


        static void GuessMachine()
        {
            string luckyWord = "sorte";
            int guessCount = 0;
            bool outOfGuesses = false;
            string guess = "";

            while(guess != luckyWord && !outOfGuesses)
            {
                if (guessCount < 5)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.WriteLine("you lose!");
            }
            else
            {
                Console.WriteLine("you win!");
            }
        }


        static void ManipArrays()
        {
            int[] luckynumbers = {11, 22, 33, 44};
            Console.WriteLine(luckynumbers[2]);

            string[] friends = new string[5];
            friends[0] = "Le";
            friends[1] = "Tety";
            friends[2] = "Je";

            Console.WriteLine(friends[1]);
        }

        static void Calculator()
        {
            //int teste = Convert.ToInt16("40");
            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator:");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine(num1 / num2);
            }
        }


        static void ManipulateStrings()
        {
            string frase = "Esta é uma frase em português.";
            int tamanhoFrase = frase.Length;

            Console.WriteLine("O tamanho da frase é " + tamanhoFrase);
            Console.WriteLine(frase.ToUpper());
            Console.WriteLine(frase.Contains("frase"));
            Console.WriteLine(frase[0] + "first | last: " + frase[frase.Length-1]);
            Console.WriteLine(frase.IndexOf('é'));
            Console.WriteLine(frase.Substring(0, 7));
            

        }

        //static void ManNumber()
        //{
            // show different numbers types, how to print them, incrementing
            // % = mod
            // Math library -> Math.Pow(), Math.Sqrt(), Math.Max(), Math.Min(), Math.Round()

        //}

        static void InputPhrases()
        {
            Console.Write("Hello, type your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

        }


        static void Story()
        {
            string characterName = "John";
            int characterAge = 35;
            Console.WriteLine("There once was a man named "+ characterName);
            Console.WriteLine("He was "+ characterAge + " years old");

        }

        static void TestingTypes()
        {
            string phrase = "I am testing a string";
            char caractere = 'a';
            int number = 5000;
            const double milesimo = 60.45;
            //float milesimo = V;  //less precise
            //double mill = 40.22;
            //decimal decc = 55.123456; // more precise
            bool isApproved = true;

            Console.WriteLine("Everything: " + phrase + caractere + number + milesimo + isApproved);
        }

        static void Triangle()
        {
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

        }

    }
}