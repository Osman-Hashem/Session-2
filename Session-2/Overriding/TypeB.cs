using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2.Overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        // Override Or Hide
        // Apply Override 
        // 1- Apply Override using 'new' Keyword
        // 1- Apply Override using 'Override' Keyword

        // Static Binding 
        // Compalier Will Bind Fuction Call Based On Reference Type Not The Object Type 
        // At Compilation 
        public new void Fun01() // using 'new' Keyword
        {
            Console.WriteLine("Fun01 From Type B ");
        }
        // Must Be Not Private And Virtual
        //public override void Fun02() // using 'Override' Keyword
        //{
        //    Console.WriteLine($"A: {A} , B : {B}");
        //}

        // Dynamic Binding 
        // CLR Will Bind The Function Call Based On Object Type Not The Refernce Type 
        // Runtime
        public override void Fun02()
        {
            Console.WriteLine($"A: {A} , B : {B}");
        }

    }
}
