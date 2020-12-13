using System;

namespace _3._1_Calculator
{
    class Program
    {
        static int Main(string[] args)
        {
            string op;
            string input = "";
            double a;
            double b;
            long c;


            if (args != null && args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    input += args[i];
                }

                input = input.ToLower().Replace(" ", "");

                op = input;
                char[] allOp = new char[] { '+', '-', 'x', '*', '\\', '/', '%', '&', '|', '^', '!', 'p', 'o', 'w' };

                string[] strArr = input.Split(allOp, StringSplitOptions.RemoveEmptyEntries);


                if (strArr.Length == 0 || strArr.Length > 2)
                {
                    return -1;
                }
                else if (strArr.Length == 1)
                {
                    op = op.Replace(strArr[0], "");
                    switch (op)
                    {
                        case "!":
                            if (long.TryParse(strArr[0], out c))
                            {
                                if (input[0] == '!')
                                {
                                    c = ~c;
                                    Console.WriteLine($"{c}");
                                }
                                else
                                {
                                    checked
                                    {
                                        try
                                        {
                                            long result = 1;

                                            while (c != 1)
                                            {
                                                result *= c;
                                                c--;
                                            }
                                            Console.WriteLine($"{result}");
                                        }
                                        catch (OverflowException e)
                                        {
                                            return -1;
                                        }
                                    }
                                }
                            }
                            break;
                        case "":
                            Console.WriteLine($"{strArr[0]}");
                            break;
                        case "-":
                            if (input[0] == '-')
                            {
                                Console.WriteLine($"-{strArr[0]}");
                            }
                            else
                            {
                                return -1;
                            }
                            break;
                        default:
                            return -1;
                    }

                }
                else
                {
                    if (Double.TryParse(strArr[0], out a) && Double.TryParse(strArr[1], out b))
                    {
                        double result = 0;
                        for (int i = 0; i < strArr.Length; i++)
                        {
                            op = op.Replace(strArr[i], "");
                        }

                        if (op.Contains("pow"))
                        {
                            if (op.Length == 5)
                            {
                                a = -a;
                                b = -b;
                            }
                            else if (op[0] == '-')
                            {
                                a = -a;
                            }
                            else
                            {
                                b = -b;
                            }
                        }
                        else if (op.Length == 3)
                        {
                            a = -a;
                            b = -b;
                        }
                        else if (op.Length == 2)
                        {
                            if (op == "--")
                            {
                                if (input[0] == '-')
                                {
                                    a = -a;
                                }
                                else
                                {
                                    b = -b;
                                }
                            }
                            else if (op[0] == '-')
                            {
                                a = -a;
                            }
                            else
                            {
                                b = -b;
                            }
                        }
                        else if (op.Length == 0)
                        {
                            //error
                            return -1;
                        }
                        else if (op.Length != 1)
                        {
                            //error
                            return -1;
                        }

                        op = op.Replace("-", "");
                        switch (op)
                        {
                            case "+":
                                result = a + b;
                                break;
                            case "":
                                result = a - b;
                                break;
                            case "*":
                            case "x":
                                result = a * b;
                                break;
                            case "/":
                            case "\\":
                                try
                                {
                                    result = a / b;
                                }
                                catch (DivideByZeroException e)
                                {
                                    return -1;
                                }
                                break;
                            case "%":
                                result = (int)a % (int)b;
                                break;
                            case "pow":
                                result = Math.Pow(a, b);
                                break;
                            case "&":
                                if (a > 0 && b > 0)
                                {
                                    result = (int)a & (int)b;
                                }
                                break;
                            case "|":
                                if (a > 0 && b > 0)
                                {
                                    result = (int)a | (int)b;
                                }
                                break;
                            case "^":
                                if (a > 0 && b > 0)
                                {
                                    result = (int)a ^ (int)b;
                                }
                                break;
                            default:
                                return -1;
                        }
                        Console.WriteLine($"{result}");
                    }
                }


                // Delay.
                Console.ReadKey();
                return 1;
            }
            else
            {
                // Introduction.
                Console.WriteLine($"Task 3.1. Made by Aleksey Kharchenko.");
                Console.WriteLine("Enter expressions in this calculator:");

                do
                {
                    input = Console.ReadLine().ToLower().Replace(" ", "");
                    op = input;
                    char[] allOp = new char[] { '+', '-', 'x', '*', '\\', '/', '%', '&', '|', '^', '!', 'p', 'o', 'w' };

                    string[] strArr = input.Split(allOp, StringSplitOptions.RemoveEmptyEntries);


                    if (strArr.Length == 0 || strArr.Length > 2)
                    {
                        Console.WriteLine("Wrong number of arguments. Enter one or two arguments. Buy Premium version to access more functions.");
                    }
                    else if (strArr.Length == 1)
                    {
                        op = op.Replace(strArr[0], "");
                        switch (op)
                        {
                            case "!":
                                if (long.TryParse(strArr[0], out c))
                                {
                                    if (input[0] == '!')
                                    {
                                        c = ~c;
                                        Console.WriteLine($"{c}");
                                    }
                                    else
                                    {
                                        checked
                                        {
                                            try
                                            {
                                                long result = 1;

                                                while (c != 1)
                                                {
                                                    result *= c;
                                                    c--;
                                                }
                                                Console.WriteLine($"{result}");
                                            }
                                            catch (OverflowException e)
                                            {
                                                Console.WriteLine(e.Message);
                                            }
                                        }
                                    }
                                }
                                break;
                            case "":
                                Console.WriteLine($"{strArr[0]}");
                                break;
                            case "-":
                                if (input[0] == '-')
                                {
                                    Console.WriteLine($"-{strArr[0]}");
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect input. Please check \"Help\" to find all possible commands.");
                                }
                                break;
                            default:
                                Console.WriteLine("Unknown operator. Please check \"Help\" to find all possible commands.");
                                break;
                        }
                    }
                    else
                    {
                        if (Double.TryParse(strArr[0], out a) && Double.TryParse(strArr[1], out b))
                        {
                            double result = 0;
                            for (int i = 0; i < strArr.Length; i++)
                            {
                                op = op.Replace(strArr[i], "");
                            }

                            if (op.Contains("pow"))
                            {
                                if (op.Length == 5)
                                {
                                    a = -a;
                                    b = -b;
                                }
                                else if (op[0] == '-')
                                {
                                    a = -a;
                                }
                                else
                                {
                                    b = -b;
                                }
                            }
                            else if (op.Length == 3)
                            {
                                a = -a;
                                b = -b;
                            }
                            else if (op.Length == 2)
                            {
                                if (op == "--")
                                {
                                    if (input[0] == '-')
                                    {
                                        a = -a;
                                    }
                                    else
                                    {
                                        b = -b;
                                    }
                                }
                                else if (op[0] == '-')
                                {
                                    a = -a;
                                }
                                else
                                {
                                    b = -b;
                                }
                            }
                            else if (op.Length == 0)
                            {
                                //error
                                Console.WriteLine("Error - no operators. Buy Premium version to access more functions.");
                                Console.ReadKey();
                                return -1;
                            }
                            else if (op.Length != 1)
                            {
                                //error
                                Console.WriteLine("Error - too many operators. Buy Premium version to access more functions. ");
                                Console.ReadKey();
                                return -1;
                            }


                            op = op.Replace("-", "");
                            switch (op)
                            {
                                case "+":
                                    result = a + b;
                                    break;
                                case "":
                                    result = a - b;
                                    break;
                                case "*":
                                case "x":
                                    result = a * b;
                                    break;
                                case "/":
                                case "\\":
                                    try
                                    {
                                        result = a / b;
                                    }
                                    catch (DivideByZeroException e)
                                    {
                                        Console.WriteLine("Exception caught: {0}", e);
                                    }
                                    break;
                                case "%":
                                    result = (int)a % (int)b;
                                    break;
                                case "pow":
                                    result = Math.Pow(a, b);
                                    break;
                                case "&":
                                    if (a > 0 && b > 0)
                                    {
                                        result = (int)a & (int)b;
                                    }
                                    break;
                                case "|":
                                    if (a > 0 && b > 0)
                                    {
                                        result = (int)a | (int)b;
                                    }
                                    break;
                                case "^":
                                    if (a > 0 && b > 0)
                                    {
                                        result = (int)a ^ (int)b;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Unknown operator. Please check \"Help\" to find all possible commands.");
                                    break;
                            }
                            Console.WriteLine($"{result}");
                        }
                    }
                    Console.WriteLine($"\nPlease enter new expression, or type \"Exit\" to end session, or type \"Help\" to get more info.");
                    input = Console.ReadLine().ToLower();

                    if (input == "exit")
                    {
                        // Delay.

                        Console.WriteLine($"\nThank you for using our program.");
                        Console.ReadKey();
                        return 1;
                    }
                    if (input == "help")
                    {
                        Console.WriteLine($"\nYou can use this calcurator by entering only one or two arguments. Amongs the provided operators are\n" +
                            $" '+', '-', 'x', '*', '\\', '/', '%', '&', '|', '^', '!', 'pow'.\nBinary operators: '+', '-', 'x', '*', '\\', '/', '%'\n" +
                            $"Binary bitwise: '&', '|', '^'\nUnary bitwise: !a\nUnary: Factorial a! and echo.\nExamples of correct expressions: 1 + 2\n1+-2\n1--2 \n12 & 3\n5!\n-5\n\n-2*-2" +
                            "Examples of incorrect expressions:\n1 + 5 + 6\n1 +-- 2\n2++2");
                        Console.ReadKey();
                    }
                } while (true);
            }
        }
    }
}