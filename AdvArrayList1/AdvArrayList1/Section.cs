using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvArrayList1
{
    class Section
    {

        String sectionName;

        //boolean addSection(String sectionName)//creates a new section if there are not already 6 sections and sectionName isnt already used
        public void addSection(String sectionName)
        {
            Console.WriteLine("Input name of section:");
            sectionName = Console.ReadLine();

            //Adds an assignment to the section
            Assignments.addAssignmentToSection("name" , 0);
        }

        //changeSection(string sectionName); sets the currently active section
        public void changeSection(String sectionName)
        {

        }

    }
}
