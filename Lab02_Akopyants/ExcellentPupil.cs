 using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_Akopyants
{
    class ExcellentPupil : Pupil
    {
        public override void Study() { Console.WriteLine("Excellent Study"); }
        public override void Read() { Console.WriteLine("Excellent Read"); }
        public override void Write() { Console.WriteLine("Excellent Write"); }
        public override void Relax() { Console.WriteLine("Excellent Relax"); }

    }
   
}
