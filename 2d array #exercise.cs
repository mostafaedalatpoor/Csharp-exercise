using System;

namespace _2d_array_example
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[,] studentlesson = new double[3, 3];
            string[] les = { "Math", "Science", "History" };
            double total ;
            double alltotal = 0;
            double average;


            for (int lesson = 0; lesson < studentlesson.GetLength(0); lesson++)
            {
                total = 0;
                string[] ex = { "FirstTerm", "MidTerm", "FinalTerm" };
                Console.WriteLine($" {les[lesson]}");
                for (int exam = 0; exam < studentlesson.GetLength(1); exam++)
                {
                    Console.Write($"enter the  {ex[exam]} exame grade: ");
                    studentlesson[lesson, exam] = Convert.ToDouble(Console.ReadLine());
                    total += studentlesson[lesson, exam];
                }
                
                average = total / studentlesson.GetLength(1);
                Console.WriteLine($"average={average}\n");
                Console.WriteLine();
                alltotal += total;
            }
            
            Console.WriteLine($"All lesson total={alltotal}\n");
            double allaverage = alltotal / studentlesson.GetLength(0);
            Console.WriteLine($"All lesson average={allaverage}");
            Console.ReadKey();
        }
    }
}
