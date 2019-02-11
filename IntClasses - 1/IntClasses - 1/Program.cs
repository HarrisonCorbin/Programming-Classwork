using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntClasses___1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student("John", 1, 15);
            myStudent.Initialize();
            myStudent.SetContentGrade(90);
            myStudent.SetWorkHabit(82);
            myStudent.SetParticipation(91);
            double grade = myStudent.GetGrade();
            myStudent.PrintGrade();
            Console.WriteLine(grade);
            Console.ReadLine();
        }
    }
}
