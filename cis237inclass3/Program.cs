using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new instance of the User Interface class
            UserInterface ui = new UserInterface();

            //Let's make an array to hold a bunch of instances of the Employee class
            SalaryEmployee[] employees = new SalaryEmployee[10];

            //Let's add some employees to our array
            employees[0] = new SalaryEmployee("David", "Barnes", 835.00m);
            employees[1] = new SalaryEmployee("James", "Kirk", 453.00m);
            employees[2] = new SalaryEmployee("Jean-Luc", "Picard", 290.00m);
            employees[3] = new SalaryEmployee("Benjamin", "Sisko", 587.00m);
            employees[4] = new SalaryEmployee("Kathryn", "Janeway", 194.00m);
            employees[5] = new SalaryEmployee("Johnathan", "Archer", 135.00m);


            //Get some input from the user
            int choice = ui.GetUserInput();

            //While the choice they selected is not 2, continue to do work
            while (choice != 2)
            {
                //See if the input they sent is equal to 1.
                if (choice == 1)
                {
                    //Create a string that can be concated to
                    string outputString = "";

                    //Print out the employees in the array
                    foreach (SalaryEmployee employee in employees)
                    {
                        if (employee != null)
                        {
                            //Concat to the outputString
                            outputString += employee.ToString() +
                                Environment.NewLine;
                        }
                    }

                    //Use the UI class to print out the string
                    ui.Output(outputString);
                }

                //re-prompt the user for input
                choice = ui.GetUserInput();
            }

        }
    }
}
