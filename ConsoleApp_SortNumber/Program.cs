using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp_SortNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input Number");

            int[] answer = new int[10];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You have entered the following Sort ASC numbers:");
            Array.Sort(answer);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(answer[i]);
            }
            Console.WriteLine("You have entered the following Sort DESC numbers:");
            Array.Reverse(answer);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(answer[i]+ " ");
            }

            Console.Write("\nSorted even numbers:");
            int sum = 0;
            foreach (int number in answer)
            {
                if (number % 2 == 0)
                {
                    sum = sum + number;
                    Console.Write(number + " ");
                }
            }
            Console.Write("\nSum is: ");
            Console.Write(sum);
            Console.Write("\nSorted odd numbers:");
            int max = 0;
            foreach (int number in answer)
            {
                if (number % 2 != 0)
                {
                    if(number > max)
                    {
                        max = number;
                    }
                    Console.Write(number+" ");
                }
            }
            Console.Write("\nMAX is : " + max);


            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();

        }
    }
}