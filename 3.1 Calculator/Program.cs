using System;

namespace _3._1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            string input;
            double a;
            double b;
            int c;
            int d;

            if (args != null && args.Length > 0 && false)
            {

            }
            else
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
                            if (int.TryParse(strArr[0], out c))
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
                                        long result = 1;
                                        while (c != 1)
                                        {
                                            result *= c;
                                            c--;
                                        }
                                        Console.WriteLine($"{result}");
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
                            Console.WriteLine("Error - too many operators");
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            //error
                            Console.WriteLine("Error - too many operators");
                            Console.ReadKey();
                            return;
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
                                result = a / b;
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
                                Console.WriteLine("Unknown operator.");
                                break;
                        }

                        Console.WriteLine($"{result}");
                    }
                }


                Console.WriteLine($"Operand is {op}");

                Console.WriteLine($"{input}");


                // Delay.
                Console.ReadKey();
            }
        }
    }
}