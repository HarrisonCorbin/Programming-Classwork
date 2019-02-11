using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntClasses___1
{
    class Student
    {
        int studentId;
        String name;
        double contentGrade;
        double workHabitGrade;
        double participation;
        int age;

        public Student(String name, int studentId, int age)
        {
            this.studentId = 0;
            this.age = 0;
        }

        public void Initialize()
        {
            name = "TestStudent";
            studentId = -1;
            contentGrade = 0;
            workHabitGrade = 0;
            participation = 0;
            age = 18;

        }

        public void SetContentGrade(int grade)
        {
            contentGrade = grade;
        }

        public void SetWorkHabit(int grade)
        {
            workHabitGrade = grade;
        }

        public void SetParticipation(int grade)
        {
            participation = grade;
        }

        public double GetGrade()
        {
            double overallGrade = (.35 * workHabitGrade) + (.4 * contentGrade) + (.25 * participation);
            return overallGrade;
        }

        public void PrintGrade()
        {
            double overallGrade = (.35 * workHabitGrade) + (.4 * contentGrade) + (.25 * participation);
            Console.WriteLine(overallGrade);
        }
    }
}
