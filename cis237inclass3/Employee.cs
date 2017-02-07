using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Employee
    {
        //Constant for the amount of weeks in a year
        protected const decimal WEEKS_PER_YEAR = 52;

        //*****************************
        //Variable / Backing fields
        //*****************************
        private string firstName;
        private string lastName;

        //*****************************
        //Properties
        //*****************************
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //******************************
        //Public Methods
        //******************************
        private string FirstAndLastName()
        {
            return firstName + " " + lastName;
        }

        public override string ToString()
        {
            return FirstAndLastName();
        }

        //Constructor

        public Employee(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }
}
