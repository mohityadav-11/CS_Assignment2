using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new HR(104, "Raj", "developer", 8000, 4, DateTime.Parse("19/12/2016"));
            Console.WriteLine(e1.salary());

            Employee e2 = new Developer(101, "Raj", "developer", 8000, 5, DateTime.Parse("12/06/2016"));
            Console.WriteLine(e2.salary());

        }
    }
}
