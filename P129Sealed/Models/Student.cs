using System;
using System.Collections.Generic;
using System.Text;

namespace P129Sealed.Models
{
    class Student : Human
    {
        //Sealed Keywordun Sahib Methodu Override Ede Bilmirik
        public sealed override string Info()
        {
            return base.Info();
        }
    }
}
