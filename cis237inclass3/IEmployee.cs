using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    interface IEmployee : ICloneable //Can have interaces Implement each other
    {
        // An interface contatins only method declarations and properties
        //There is no need to use access modifiers implied as always public
        //We are specifiying only public methods and properties

        //Any class that implements this interface must implement the following
        //Methods
        string GetFormattedSalary();

        string GetLastNameFirstName();

        //Poperties
        string FirstName
        {
            get;
            set;
        }
        String LastName
        {
            get;
            set;
        }
    }
}
