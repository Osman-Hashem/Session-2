using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2.Overriding
{
    internal class TypeA
    {
        public int A { get; set; }

        public void Fun01()
        {
            Console.WriteLine("Fun01 From Type A ");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"A: {A}");
        }
    }
}
