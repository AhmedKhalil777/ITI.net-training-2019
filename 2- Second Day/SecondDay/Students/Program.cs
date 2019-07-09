using System;

namespace Students
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Num of Students :");
            int NumStudents = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Num of Subjects :");
            int NumSubjects = int.Parse(Console.ReadLine());
            int[,] Subjects = new int[NumStudents, NumSubjects];

            for (int i = 0; i < NumStudents; i++)
            {
                for (int j = 0; j < NumSubjects; j++)
                {
                    Console.Write("Enter the Subject {0} of Student {1} : ", j+1,i+1 );
                    Console.WriteLine();
                    Subjects[i, j] = int.Parse(Console.ReadLine());

                }
            }
            int[] result = new int[NumStudents];
            double[] average = new double[NumSubjects];
            for (int i = 0; i < NumStudents; i++)
            {
                for (int j = 0; j < NumSubjects; j++)
                {
                    result[i] += Subjects[i, j];

                }
                Console.WriteLine("The {0} student result = {1}",i+1,result[i]);
            }
            for (int i = 0; i < NumSubjects; i++)
            {
                for (int j = 0; j < NumStudents; j++)
                {
                    average[i] += Subjects[j, i];

                }
                average[i] /= NumSubjects;

                Console.WriteLine("The {0} subject average = {1}", i + 1, average[i]);
            }
        }
    }
}
