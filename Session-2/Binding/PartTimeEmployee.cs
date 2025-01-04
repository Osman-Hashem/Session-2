using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2.Binding
{
    internal class PartTimeEmployee : Employee
    {
        
        public double HourRate { get; set; }
        public double NumberOfHoure { get; set; }


        public new void Fun01()
        {
            Console.WriteLine("I am Part Time Employee ");
        }

        public override void Fun02()
        {
            Console.WriteLine($"Salary : {HourRate * NumberOfHoure}");
        }
    }
}
