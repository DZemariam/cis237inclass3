using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class SalaryEmployee : Employee
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        private decimal weeklySalary;

        //*****************************
        //Properties
        //*****************************


        public decimal Salary
        {
            get
            {
                return weeklySalary * WEEKS_PER_YEAR;
            }
        }

        //******************************
        //Public Methods
        //******************************


        public override string ToString()
        {
            return base.ToString() + " " + weeklySalary.ToString("C");
        }

        //*****************************
        //Constructors
        //*****************************
        public SalaryEmployee(string FirstName, string LastName, 
                                decimal WeeklySalary) :
                                    base( FirstName, LastName)
        {

            this.weeklySalary = WeeklySalary;
        }
    }
}
