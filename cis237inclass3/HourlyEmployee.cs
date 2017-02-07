using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class HourlyEmployee : Employee
    {
        //Constant for the amount of weeks in a year
        private const decimal WEEKS_PER_YEAR = 52;
        //*****************************
        //Variable / Backing fields
        //*****************************
        private decimal hourlyRate;
        private decimal hoursPerWeek;

        //Properyies

        //THis will be a property to get the Yearly Salary
        public decimal Salary
        {
            get
            {
                return this.hourlyRate * WEEKS_PER_YEAR * hoursPerWeek;
            }
        }

        //******************************
        //Public Methods
        //******************************
      
        public override string ToString()
        {
            //Make call to the parent class version of ToString to get first and last name part of string, then concat it to salary
            return base.ToString() + " " + Salary.ToString("C");
        }

        //*****************************
        //Constructors
        //*****************************
        /*Declare a 4 Parameter constructor that takes everthing that we need. Then calls teh parenter constructor to have
         the parent take care of assigning the passed in first and last name variables.
         This is done by adding " : base(parameter, parameter)  after the constructor defition*/
        
        public HourlyEmployee(string FirstName, string LastName, 
                                decimal HoursPerWeek, decimal HourlyRate) :
                                    base(FirstName, LastName)
        {
            this.hoursPerWeek = HoursPerWeek;
            this.hourlyRate = HourlyRate;
        }
    }
}
