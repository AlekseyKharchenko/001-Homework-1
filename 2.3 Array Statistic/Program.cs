using System;

namespace _2._3_Array_Statistic
{
    class Program
    {
        public static void QuickSort(int[] array, int left, int right)
        {
            if (left > right || left < 0 || right < 0) return;

            int index = Partition(array, left, right);

            if (index != -1)
            {
                QuickSort(array, left, index - 1);
                QuickSort(array, index + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            if (left > right) return -1;

            int end = left;

            int pivot = array[right];
            for (int i = left; i < right; i++)
            {
                if (array[i] < pivot)
                {
                    Swap(array, i, end);
                    end++;
                }
            }

            Swap(array, end, right);
            return end;
        }

        private static void Swap(int[] array, int left, int right)
        {
            int tmp = array[left];
            array[left] = array[right];
            array[right] = tmp;
        }
        static public void displayArray(int[] array, int arrSize)
        {
            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        static int Main(string[] args)
        {
            int arrSize = 0;
            int[] array = null;
            int min, max;
            int sum = 0;
            double mean = 0.0;
            double deviation = 0.0;

            if (args != null && args.Length > 0)
            {
                try
                {
                    if (args.Length <= 0)
                    {
                        return -1;
                    }
                    else
                    {
                        arrSize = args.Length;
                        array = new int[arrSize];

                        for (int i = 0; i < arrSize; i++)
                        {
                            array[i] = int.Parse(args[i]);
                        }
                    }
                }
                catch (FormatException)
                {
                    return -1;
                }
                catch (ArgumentOutOfRangeException)
                {
                    return -1;
                }

                if (array != null)
                {
                    QuickSort(array, 0, arrSize - 1);
                    displayArray(array, arrSize);
                }
                else
                {
                    return -1;
                }

                Console.ReadKey();
                return 1;
            }
            else
            {
                // Introduction.
                Console.WriteLine("Task 2.3. Made by Aleksey Kharchenko.");
                Console.WriteLine("My program sorts entered array and displays a bunch of scientific stuff:");
                Console.WriteLine("\tMinimum element");
                Console.WriteLine("\tMaximum element");
                Console.WriteLine("\tSum of elements");
                Console.WriteLine("\tArithmetical mean");
                Console.WriteLine("\tStandard deviation");


                // Inputing array.
                Console.WriteLine("\n\nPlease enter the size of array: ");

                do
                {
                    try
                    {
                        arrSize = int.Parse(Console.ReadLine());

                        if (arrSize <= 0)
                        {
                            Console.WriteLine("Invalid array size. Please enter please enter number bigger than zero.");
                        }
                        else
                        {
                            array = new int[arrSize];

                            Console.WriteLine("Now please fill each element of array.");
                            for (int i = 0; i < arrSize; i++)
                            {
                                Console.Write($"{i + 1}th element = ");
                                array[i] = int.Parse(Console.ReadLine());
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please try using digits and not any kind of symbols.");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Invalid array size. Please input the number that is begger than zero."); ;
                    }
                } while (arrSize <= 0);


                // Processing array.
                if (array != null)
                {
                    QuickSort(array, 0, arrSize - 1);

                    Console.WriteLine("Sorted array is:");
                    displayArray(array, arrSize);

                    min = max = array[0];
                    sum += array[0];

                    for (int i = 1; i < arrSize; i++)
                    {
                        if (array[i] > max)
                        {
                            max = array[i];
                        }
                        if (array[i] < min)
                        {
                            min = array[i];
                        }
                        sum += array[i];
                    }

                    mean = sum / arrSize;

                    for (int i = 0; i < arrSize; i++)
                    {
                        deviation += (array[i] - mean) * (array[i] - mean);
                    }
                    Console.WriteLine($"\n\tMin = {min}\n\tMax = {max}\n\tSum = {sum}\n\tMean = {mean}\n\tDeviation = {deviation}");
                }
                else
                {
                    Console.WriteLine("Array is empty.");
                }


                // Delay.
                Console.ReadKey();
                return 1;
            }
        }
    }
}
