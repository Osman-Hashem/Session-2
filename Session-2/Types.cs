﻿namespace Session_2
{
    class TypeA
    {
        public int A { get; set; }

        public void Fun01()
        {
            Console.WriteLine(" Fun01 From Type A ");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"A : {A}");
        }


    }

    class TypeB : TypeA
    {
        public int B { get; set; }

        public new void Fun01()
        {
            Console.WriteLine(" Fun01 From Type B ");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A : {A} , B : {B}");
        }

    }

    class TypeC : TypeB
    {
        public int C { get; set; }

        public new void Fun01()
        {
            Console.WriteLine(" Fun01 From Type C ");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A : {A} , B : {B} , C : {C}");
        }

    }

    class TypeD : TypeC
    {
        public int D { get; set; }

        public new void Fun01()
        {
            Console.WriteLine(" Fun01 From Type D ");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A : {A} , B : {B} , C : {C} , D : {D}");
        }

    }

    class TypeE : TypeD
    {
        public int E { get; set; }

        public new void Fun01()
        {
            Console.WriteLine(" Fun01 From Type E ");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A : {A} , B : {B} , C : {C} , D : {D} , E : {E} ");
        }

    }














}