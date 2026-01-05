using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("What's your name: ");
            string? userName = Console.ReadLine();
            Console.WriteLine($"Welcome to Calculator, {userName}");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            string? choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Goodbye");
                break;
            }

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    break;

                case "2":
                    result = num1 - num2;
                    break;

                case "3":
                    result = num1 * num2;
                    break;

                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed");
                        continue;
                    }
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    continue;
            }

            Console.WriteLine($"Result: {result}");
            Console.WriteLine();
        }
    }
}