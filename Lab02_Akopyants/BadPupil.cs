using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_Akopyants
{
    class BadPupil : Pupil
    {
        public override void Study() { Console.WriteLine("Bad Study"); }
        public override void Read() { Console.WriteLine("Bad Read"); }
        public override void Write() { Console.WriteLine("Bad Write"); }
        public override void Relax() { Console.WriteLine("Bad Relax"); }
    }
}
