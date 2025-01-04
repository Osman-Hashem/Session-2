using Session_2.Binding;
using Session_2.Overriding;

namespace Session_2
{
    internal class Program
    {

        #region 3-1- Polymorphism Method [Function] Overloading
        //static int Sum(int x, int Y , int Z)
        //{
        //    return x + Y;
        //}
        //static int Sum(int x , int Y)
        //{
        //    return x + Y;
        //}

        //static double Sum(double x, double Y)
        //{
        //    return x + Y;
        //}

        //static double Sum(int x, double Y)
        //{
        //    return x + Y;
        //}

        //static double Sum(double x, int Y)
        //{
        //    return x + Y;
        //} 
        #endregion



        //static void EmployeeProcess(FullTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }
        //}
        //static void EmployeeProcess(PartTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }
        //}

        //static void EmployeeProcess(Employee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }
        //}



        static void Main()
        {
            #region Class Vs Struct
            // Class Vs Struct :   

            #endregion

            #region Inheritance
            // 2- Inheritance :
            // X → Y 
            // DRY 


            //Parent parent = new Parent(1, 2);

            ////Console.WriteLine(parent);

            //parent.Fun01();
            //parent.Fun02();

            //Child child = new Child(1 , 2 , 3);

            //Console.WriteLine(child);

            //child.Fun01();
            //child.Fun02(); 
            #endregion

            #region Relationships Between Classes
            // Relationships Between Classes

            // 1- Inheritance : Is A Relationship :

            // FullTimeEmployee ----> Employee
            // FullTimeEmployee is a Employee

            // Child ----> Parent
            // Child is a Parent

            //Child child =new Child(1,2,3);


            // 2- Association : Has A Relationship :

            // Book Has A Author 
            // Library Has A Books 

            // 2-1- Composition  Has A Relationship
            // 2-2- Aggregation  Has A Relationship 
            #endregion

            #region Polymorphism
            // 3- Polymorphism :  

            #region 3-1- Polymorphism Method [Function] Overloading
            // 3-1- Polymorphism Method [Function] Overloading

            // There Are More Than One Function (In The Same Scope [Class - Struct])
            // These Have Yhe Same Name But With Different Signature 
            // (Count - Type - Oeder) Parameters

            //Sum(1, 2); 
            #endregion

            #region 3-2- Polymorphism Method [Function] Overriding
            // 3-2- Polymorphism Method [Function] Overriding

            // There Are More Than One Function [In Different Class] These Function Have The Same Name 
            // ANd The Same Signature But With Behaviour

            //TypeB typeB = new TypeB() { A = 12, B = 13 };

            ////typeB.A = 12;
            ////typeB.B = 13;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            //typeB.Fun01();
            //typeB.Fun02(); 
            #endregion

            #endregion

            #region  What is Binding ? 
            // Binding : 
            // What is Binding ? 

            // Reference from Parent ---> Object Child

            //TypeA Ref;
            //Ref = new TypeA();

            // Child is a Parent 

            // TypeB is a TypeA

            //Ref = new TypeB();

            //Ref.A = 12;
            ////Ref.B = 12;

            ////Ref.Fun01(); // Static Binded Methods 
            //Ref.Fun02(); 
            #endregion

            #region Not Binding
            // Binding 
            // RefParent -----> ObjChild


            //TypeA Ref = new TypeA();

            //Ref = new TypeB(); // Binding 

            //--------------

            //TypeB Ref = new TypeB();

            //Ref = new TypeA(); //  invalid 

            // Child is a Parent 

            // Animal --> Dog : Dog is a animal 
            // Dog --> (Dog) Animal : Animal Is a Dog 

            //TypeA Ref = new TypeA();
            //Ref = new TypeB();

            //TypeB typeB = (TypeB)Ref; // Not Binding  
            #endregion

            #region When U Need Binding ??
            // When U Need Binding ?? 

            // FullTimeEmoployee : ID , Name , Address , Email , Salary 
            //FullTimeEmployee fullTime = new FullTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Ahmed",
            //    Email = "Ahmed@g.c",
            //    Address = "Cairo",
            //    Salary = 12000
            //};

            //// PartTimeEmployee : Id , Name , Address , Email , NumberOfHours , HoursRate 


            //PartTimeEmployee partTime = new PartTimeEmployee()
            //{
            //    Id = 2,
            //    Name = "Ali",
            //    Email = "Ali@g.c",
            //    Address = "Alex",
            //    HourRate = 300,
            //    NumberOfHoure = 200
            //};



            //EmployeeProcess(partTime);

            //EmployeeProcess(null); // NullReferenceExcpetion

            //EmployeeProcess(fullTime);
            //EmployeeProcess(partTime); 
            #endregion

            #region Ex Of Ttpes
            //TypeA typeA;

            //typeA = new TypeA();
            //typeA = new TypeB();  // TypeA is a Parent Of TypeB
            //typeA = new TypeC();  // TypeA is a Indriect Parent Of TypeC
            //typeA = new TypeD();  // TypeA is a Indriect Parent Of TypeD
            //typeA = new TypeE();  // TypeA is a Indriect Parent Of TypeD

            //typeA.A = 12;
            ////typeA.B = 12;
            ////typeA.C = 12;
            ////typeA.D = 12;

            //typeA.Fun01();
            //typeA.Fun02();
            #endregion

        }
    }
}
