using System;

namespace StudentTotalScore
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int marks, max = 0, min = 100, Sum = 0;

            double Avg;
            for (int a = 1; a < 8; a++){

                Console.Write("Ener Mark - " + a + ": ");
                marks = Convert.ToInt16(Console.ReadLine());
                Sum = Sum + marks; //Sum+ = mark; Commulative summation

                if (marks < min)
                {
                    min = marks; //Has to deal with the minimum or the lowest score
                }
                if (marks > max)
                {
                    max = marks;//has to deal with the maximum or hte highest score
                }
            }
            Avg = (float)Sum / 7; // Calculate the average

            Console.WriteLine("\ntotal Score : " + Sum +
                "\nHighest Score : " + max + "\nLowest score : " + min +
                "\nAverage Score : " + Avg + "\n"); ; // Display an answers
        }
        
    }
}
