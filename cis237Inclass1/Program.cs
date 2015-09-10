using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Seynabou", "Diagne", 24);

            Person person2 = new Person("Abou", "Mbodji", 27);

            person1.PrintFullName();
            person1.PrintAge();
            Console.WriteLine();
            person2.PrintFullName();
            person2.PrintAge();

            Console.WriteLine("\n\n");

            person1.Identity();
            Console.WriteLine("\n");
            person2.Identity();


            Console.ReadLine();
        }
    }
}
