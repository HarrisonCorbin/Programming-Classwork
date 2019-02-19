using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvArrayList1
{
    class Assignments
    {
        int pointsPossible;
        int pointsReceived;
        int scorePercent;
        String assignmentName;

        //boolean addAssignmentToStudent(String username, String assignmentName, int pointsPossible)
        public void addAssignmentToStudent(String username, String assignmentName, int pointsPossible)
        {
            Console.WriteLine("Input name of the assignment:");
            assignmentName = Console.ReadLine();
            Console.WriteLine("Input Assignment Score:");
            pointsReceived = Convert.ToInt32(Console.ReadLine());

            //Inputs Assignment into a list of assignments used to calculate the score

        }
        //boolean addAssignmentToSection(String assignmentName, int pointsPossible)
        public void addAssignmentToSection(String assignmentName, int pointsPossible)
        {
            Console.WriteLine("Input name of the assignment:");
            assignmentName = Console.ReadLine();
            Console.WriteLine("Input Assignment Score:");
            pointsReceived = Convert.ToInt32(Console.ReadLine());

            //Inputs Assignment into the Section Class

        }
        //double getAssignmentScorePercent(String username, String assignmentName) //returns score as a percentage for student in current section
        public double getAssignmentScorePercent(String username, String assignmentName)
        {
            scorePercent = pointsReceived / pointsPossible;
            return scorePercent;
        }
        //double getAssignmentScoreAvg(String assignmentName) //returns score as a percentage for current section
        public void getAssignmentScoreAvg(String assignmentName)
        {
           
        }
    }
}
