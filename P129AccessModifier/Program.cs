using System;
using P129AccessModifier.DemoNS;
using Test;
using P129DemoLibrary.Models;


//Classlarin Default Access Modifier Internal
//Class 2 Access Modifiere Sahib Ola Bilir 1- Internalr 2-Public
//Classin Memberler de Internal Access Modifierna Sahib Ola Bilir

//protected internal - bu access modifier sahib olan member oz project(assambly ) daxilinde her yerden
//elcatan olur amma xarici ozunu protected kimi aparir

//private protected - bu access modifier sahib olan member oz project(assambly) daxilinde ozunu protected
//xarici projectde ozunu private


namespace P129AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            DemoNS.Car car1 = new DemoNS.Car();

            MyClass myClass = new MyClass();

            Test.Car car2 = new Test.Car();

            Models.Test test = new Models.Test();

            Student student = new Student();
        }
    }

    namespace DemoNS
    {
    }
}

namespace Test{
    class MyClass : Car
    {

    }

    class Car : Student
    {

        public Car()
        {
        }
        public string Model { get; set; }
    }
}
