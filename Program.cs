using System;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Press CTRL - F5 to run code

            // How to Write to logs
            Console.WriteLine("Hello Word");

            // Integers
            int num = 69;
            Console.WriteLine("This is an Interger Variable: " + num);

            // Strings
            string word = "I came in my pants";
            Console.WriteLine("This is an String Variable: " + word);

            // Booleans
            bool tf = true;
            Console.WriteLine("This is an Boolean Variable: " + tf);

            // If statemes
            if (tf)
            {
                Console.WriteLine("The Boolean is true");
            }
            else
            {
                Console.WriteLine("The Boolean is false");
            }

            // While loop
            int count = 0;
            while (tf)
            {
                Console.WriteLine("Fuck me");

                if (count == 10)
                {
                    tf = false;
                }

                count++;
            }

            // For loop
            for (int x = 0; x <= 10; x++)
            {
                Console.WriteLine("Which iteration: " + x);
            }

            // Switch Cases
            switch (10)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                    break;
                case 10:
                    Console.WriteLine("This is the case of 10");
                    break;

            }

            // User input
            // String input
            Console.WriteLine("String input: ");
            string stringInput = Console.ReadLine();
            Console.WriteLine("String String input: " + stringInput);

            // Int input
            Console.WriteLine("Integer input: ");
            string intInput = Console.ReadLine();
            try
            {
                int intput = Int32.Parse(intInput);
                Console.WriteLine("String Integer input: " + intInput);
            } catch (FormatException e)
            {
                Console.WriteLine(e);
            }

            // Random Number generator
            Random rand = new Random();
            int randNum = rand.Next(1, 100);
            Console.WriteLine("Random number generator: " + randNum);

            

        }
    }
}
