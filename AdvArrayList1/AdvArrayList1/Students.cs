using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvArrayList1
{
    class Students
    {
        String firstname;
        String lastName;
        String username;
        long phoneNumber;

        //boolean AddStudent(String firstName, String lastName, string username, long phoneNumber); //creates a new student
        public void AddStudent(String firstName, String lastName, String username, long phoneNumber)
        {
            Console.WriteLine("Input Student's first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Input Student's last name");
            lastName = Console.ReadLine();
            Console.WriteLine("Input new username");
            username = Console.ReadLine();
            Console.WriteLine("Input Student's last name");
            phoneNumber = Convert.ToInt32(Console.ReadLine());
        }

        public void fileAssignmentToStudent(String username, String assignmentName, int pointsPossible)
        {
            Assignments.addAssignmentToStudent("username" , "name", 0);
        }
}
