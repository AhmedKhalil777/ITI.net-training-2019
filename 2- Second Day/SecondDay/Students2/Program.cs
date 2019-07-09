using System;

namespace Students2
{
    class Program
    {
        struct Student
        {
            public string Name;
            public int[] Subjects;
            public int Result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter The Num of Students :");
            int NumStudents = int.Parse(Console.ReadLine());
            Student[] stud = new Student[NumStudents];

            for (int i = 0; i < NumStudents; i++)
            {
                Console.WriteLine("Enter the name of Student {0}" , i+1);
                stud[i].Name= Console.ReadLine();

            }
            int[] Result = new int[NumStudents];
            for (int i = 0; i < NumStudents; i++)
            {
                Console.WriteLine("Enter The num of Subjects for student :{0}", stud[i].Name);
                int x = int.Parse(Console.ReadLine());
                stud[i].Subjects = new int[x];


            }




            for (int i = 0; i < NumStudents; i++)
            {
                Console.WriteLine("Enter The Degrees of Student{0}:", stud[i].Name);
                for (int j = 0; j <stud[i].Subjects.Length; j++)
                {
                    Console.WriteLine("Enter the Subject degree {0}", j+1);
                    int x = int.Parse(Console.ReadLine());
                    stud[i].Subjects[j] = x;

                }
            }
            for (int i = 0; i < NumStudents; i++)
            {
                for (int j = 0; j < stud[i].Subjects.Length; j++)
                {
                    stud[i].Result += stud[i].Subjects[j];

                }
                Console.WriteLine("The Result of {0} = {1}", stud[i].Name, stud[i].Result);
            }

            


        }
    }
}
