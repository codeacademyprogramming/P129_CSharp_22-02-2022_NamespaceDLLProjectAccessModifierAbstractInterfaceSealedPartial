using P129Interfce.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P129Interfce.Models
{
    //Class Yalniz Bir Class-dan Inherit Ede Biliri Ve Isdediymiz Interface-den
    //Birinci Class Sora Interfaceler siralanir
    class Student : Human, IWalk, IRun
    {
    }
}
