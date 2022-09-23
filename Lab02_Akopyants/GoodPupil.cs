using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_Akopyants
{
    class GoodPupil : Pupil
    {
        public override void Study() { Console.WriteLine("Good Study"); }
        public override void Read() { Console.WriteLine("Good Read"); }
        public override void Write() { Console.WriteLine("Good Write"); }
        public override void Relax() { Console.WriteLine("Good Relax"); }
    }
}
