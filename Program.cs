using System;

public class Calculation
{
    static void Main(string[] args)
    {
        if (args.Length >=3)
        {
            try
            {
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                string op = args[2];

                switch (op)
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                        try
                        {
                            Console.WriteLine(a/b);
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown operator.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Not enough arguments were provided.");
        }
    }
}
