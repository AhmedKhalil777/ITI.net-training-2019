using System;
using System.Globalization;

namespace Company
{
    class Program
    {
        struct HiringDate
        {
            public HiringDate(int D, int M , int Y)
            {
                Day = D;
                Month = M;
                Year = Y;
            }
           public int Day;
           public int Month;
           public int Year;
        }

        [Flags]
        enum SecurityLevel
        {
            Guest = 1,
            Developer = 2,
            Secretary = 4,
            DBA = 8,
            
        }
        

        enum Gender
        {
            M , F
                
        }
        struct Employee
        {
            public Employee(int ID , HiringDate hiringDate , double Salary , SecurityLevel level , Gender gender)
            {
                this.ID = ID;
                HD = hiringDate;
                this.Salary = Salary;
                SL = level;
                this.gender = gender;

            }
            public int ID { get; set; }
            public HiringDate HD { get; set; }
            public double Salary { get; set; }
            public SecurityLevel SL { get; set; }
            public Gender gender { get; set; }

            public override string ToString()
            {


                return     "Employee ID :" + ID +
                           "\n Hiring Date :" + HD.Day +" / "+ HD.Month + " / "+ HD.Year +
                           "\n Employee Salary :" + Salary.ToString("c3", CultureInfo.CurrentCulture) +
                           "\n Security Level :" + SL +
                           "\n Gender :" + gender;
            }

        }
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3] {
                new Employee(1,new HiringDate(1,1,1998),10000,SecurityLevel.DBA,Gender.M),
                 new Employee(2,new HiringDate(1,1,2009),10000,SecurityLevel.Secretary,Gender.F),
                new Employee(3,new HiringDate(1,1,1998),10000, SecurityLevel.DBA | SecurityLevel.Developer | SecurityLevel.Guest | SecurityLevel.Secretary,Gender.M),
            };
            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString()); 
            }


            

        }
    }
}
