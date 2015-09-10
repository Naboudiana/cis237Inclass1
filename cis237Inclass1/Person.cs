using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Person
    {
        string firstName;
        string lastName;
        int Age;


        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }

        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }

        }

        public int age
        {
            get
            {
                return this.Age;
            }
            set
            {
                this.Age = value;
            }

        }

        public Person()
        {
            
        }

        public Person(string firstName, string lastName, int Age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Age = Age;
        }

        public void PrintFullName()
        {
            Console.WriteLine(this.firstName + ' ' + this.lastName);
        }

        public void PrintAge()
        {
            Console.WriteLine(this.Age);
        }

        public void Identity()
        {
            Console.WriteLine("Name= " + this.firstName + ' ' + this.lastName);
            Console.WriteLine("Age= " + this.Age);
        }


      
    }
}
