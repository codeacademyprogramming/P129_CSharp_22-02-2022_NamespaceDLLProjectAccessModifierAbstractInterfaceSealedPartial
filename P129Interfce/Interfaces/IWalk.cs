using System;
using System.Collections.Generic;
using System.Text;

namespace P129Interfce.Interfaces
{
    //Interface Memberleri Method Ve Propertyler Ola Bilir
    //Interface-den Instance Yarada Bilmirik
    //Interface Abstraction baxa Bilirik
    interface IWalk
    {
        //Interface Daxilinde Yazilan Method Methoda Aid Butun Xususiyyetleri Dasiyir
        void Walk();
        public double Millage { get; set; }
    }
}
