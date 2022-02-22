using System;
using System.Collections.Generic;
using System.Text;

namespace P129Abstraction.Models
{
    //Abstract Keywordun Sahib Olan Class Instance Yarada Bilmirik ve
    //Digger Classlarin Butun Xususiyyetini Dasiyir

    //Abstract Keywordun Sahib Olan Methodun Body-si Olmur ve Yalniz abstract
    //keywordun sahib olan class-in icinde yazilir ve Body-si klasst mirass alan adi klassda yazilir
    //ve hemcinin methodlar aid olan butun xususiyyetleri
    abstract class Animal
    {
        public int Age;
        public bool Gender;

        //Polymorphisym
        public abstract void Eat();
    }
}
