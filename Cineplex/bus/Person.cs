using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cineplex.bus
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public string FirstName 
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public Person()
        {
            this.lastName = "";
            this.lastName = "";
        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string GetPersonName()
        {
            string name;
            name = this.firstName + " " + this.lastName;

            return name;
        }
    }
}
