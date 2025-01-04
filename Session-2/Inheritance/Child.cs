﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2.Inheritance
{
    internal class Child : Parent
    {

        public int Z { get; set; }

        public Child(int X , int Y , int Z) : base(X , Y)
        {
            this.Z = Z;
        }

        // Override Or Hide :-

        public void Fun01()
        {
            Console.WriteLine("I am Child ");
        }

        public void Fun02()
        {
            Console.WriteLine($"X : {X}, Y : {Y} , Z : {Z}");
        }


        public override string ToString()
        {
            return $"X : {X}, Y : {Y} Z : {Z}";
        }
    }
}
