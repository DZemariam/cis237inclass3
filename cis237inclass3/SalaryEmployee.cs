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
            return base.ToString() + " " + Salary.ToString("C");
        }

        //this is the clone method that we had to write an implementation for 
        //because its parent class has declared the method abostract which the interface needs implemented.
        public override string GetFormattedSalary()
        {
            return Salary.ToString("C");
        }

        public override object Clone()
        {
            return new SalaryEmployee(this.FirstName, this.LastName, weeklySalary);
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
