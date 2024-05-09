using System;
class Normal
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Choose The Calculator");
            Console.WriteLine("1. Normal calculator");
            Console.WriteLine("2. Scientific Calculator");
            Console.WriteLine("3. Exit");

            Console.Write("Enter Your Choise : ");
            if (!int.TryParse(Console.ReadLine(), out int select))
            {
                Console.WriteLine("Invalid Choise. Please Entre a Valid Value");
                continue;
            }
            switch (select)
            {
                case 1:
                    Normalcalculator();
                    break;

                case 2:
                    Scientificcalculator();
                    break;

                case 3:
                    Console.WriteLine(" ");
                    Console.WriteLine("You Sure");
                    Console.Write("1. Yes ,");
                    Console.WriteLine(" 2. No");
                    if (!int.TryParse(Console.ReadLine(), out int Exit))
                    {
                        Console.WriteLine("Entre a Valid Value");
                        return;

                    }
                    switch (Exit)
                    {
                        case 1:
                            Console.WriteLine("Exiting program [ PRESS ANY KEY TO CLOSE !!!]..."); // Informing the user of program exit
                            return;

                        case 2:
                            continue;
                    }

                    return;
                default:
                    Console.WriteLine("Invalid Choise");
                    break;
            }


        }

    }
    static void Normalcalculator()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Normal Calculator");
        Console.WriteLine("Entre a First Value");
        if (!int.TryParse(Console.ReadLine(), out int value1))
        {
            Console.WriteLine("Entre a Valid Value");
            return;
        }

        Console.WriteLine("Entre a Second Value");
        if (!int.TryParse(Console.ReadLine(), out int value2))
        {
            Console.WriteLine("Entre a Valid Value");
            return;
        }

        Console.WriteLine("Select the Operation");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiple (*)");
        Console.WriteLine("4. Division (/)");
        Console.WriteLine("5. Percent (%)");
        Console.Write("Enter Your Choise : ");

        if (!int.TryParse(Console.ReadLine(), out int calculate))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        };

        int Result = 0;
        int Offer = 100;
        switch (calculate)
        {
            case 1:
                Result = value1 + value2; break;

            case 2:
                Result = value1 - value2; break;

            case 3:
                Result = value1 * value2; break;

            case 4:
                Result = value1 / value2; break;

            case 5:
                Result = value1 * value2 / Offer;
                break;

            default:
                Console.WriteLine("Invalid Operation");
                return;

        }
        Console.WriteLine(" ");
        Console.WriteLine($"Result: {Result}");
    }

    static void Scientificcalculator()
    {
        
        Console.WriteLine(" ");
        Console.WriteLine("Scientific Calculator");
        Console.WriteLine("Enter a number:");

        
        if (!double.TryParse(Console.ReadLine(), out double sin1))
        {
         
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return; 
        }

        
        Console.WriteLine("Choose Operation:");
        Console.WriteLine("1. Exponentiation (x ^ y)");
        Console.WriteLine("2. Square Root (√x)");
        Console.WriteLine("3. Logarithm (log10)");
        Console.WriteLine("4. Sine (sin)");
        Console.WriteLine("5. Cosine (cos)");
        Console.WriteLine("6. Tangent (tan)");
        Console.Write("Enter your Choice: ");
        if (!int.TryParse(Console.ReadLine(), out int operation))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        double Result = 0;
        switch (operation)
        {
            case 1:
                Console.Write("Enter the exponent: ");
                if (!double.TryParse(Console.ReadLine(), out double exponent))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                Result = Math.Pow(sin1, exponent); 
                break;

            case 2:
                Result = Math.Sqrt(sin1);
                break;

            case 3:
                Result = Math.Log10(sin1);
                break;

            case 4:
                Result = Math.Sin(sin1); 
                break;

            case 5:
                Result = Math.Cos(sin1); 
                break;

            case 6:
                Result = Math.Tan(sin1); 
                break;

            default:
                Console.WriteLine("Invalid Operation"); 
                return;
        }
        Console.WriteLine(" ");
        Console.WriteLine($"Result: {Result}");
    }
};
