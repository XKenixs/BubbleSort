using System;
using System.Threading;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int num;
            Console.WriteLine("Enter your numbers to sort");
            Console.WriteLine("Please seperate the numbers with a 'comma'. \n");
            //input
            Console.Write(">>> ");
            string input = Console.ReadLine();
            string[] input_array = input.Split(",");

            int[] input_array_as_int = new int[input_array.Length];
            //string array to int array
            for (int i = 0; i < input_array.Length; i++)
            {
                //error, if invalid chars
                try
                {
                    num = Int32.Parse(input_array[i]);
                    input_array_as_int[i] = num;
                }
                catch
                {
                    Console.WriteLine("Error, please enter a valid number!");
                    return;
                }
            }
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");

            for (int element = 1; element <= input_array_as_int.Length; element++)
            {
                Console.ResetColor();
                //Console.WriteLine(input_array_as_int[element - 1]);
                for (int z = 1; z <= input_array_as_int[element - 1]; z++)
                {
                    if (input_array_as_int[element - 1] % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("█");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" {input_array_as_int[element - 1]}");
                //Console.WriteLine("\u00A0");
            }

            Console.WriteLine("------------------------------------------------------");
            //BubbleSort    
            for (int j = 0; j <= input_array_as_int.Length - 2; j++)
            {
                for (int i = 0; i <= input_array_as_int.Length - 2; i++)
                {
                    if (input_array_as_int[i] > input_array_as_int[i + 1])
                    {
                        temp = input_array_as_int[i + 1];
                        input_array_as_int[i + 1] = input_array_as_int[i];
                        input_array_as_int[i] = temp;

                        switch (input_array_as_int.Length)
                        {
                            case int n when n < 4:
                                Thread.Sleep(2000);
                                break;
                            case int n when n <= 8 && n > 4:
                                Thread.Sleep(1000);
                                break;
                            case int n when n > 8:
                                Thread.Sleep(500);
                                break;
                        }
                        
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------");
                        for (int element = 1; element <= input_array_as_int.Length; element++)
                        {
                            Console.ResetColor();
                            //Console.WriteLine(input_array_as_int[element - 1]);
                            for (int z = 1; z <= input_array_as_int[element - 1]; z++)
                            {
                                if (input_array_as_int[element - 1] % 2 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }
                                else Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("█"); 
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($" {input_array_as_int[element - 1]}");
                            //Console.WriteLine("\u00A0");
                        }
                        
                        Console.WriteLine("------------------------------------------------------");
                    }
                }
            }
            //output
            Console.WriteLine("Start values:");
            for (int i = 0; i < input_array.Length; i++)
            {
                Console.Write(input_array[i] + ", ");
            }

            Console.WriteLine("\nSorted:");
            for (int i = 0; i < input_array_as_int.Length; i++)
            {
                Console.Write(input_array_as_int[i] + ", ");
            }
        }
    }
}
