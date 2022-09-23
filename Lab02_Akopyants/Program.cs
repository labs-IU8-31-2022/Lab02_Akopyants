using System;

namespace Lab02_Akopyants
{
    class Program
    {
        static void Main(string[] args)
        {
            GoodPupil good = new GoodPupil();
            BadPupil bad = new BadPupil();
            ExcellentPupil ex = new ExcellentPupil();
            GoodPupil good2 = new GoodPupil();

            Class_Room _Class = new Class_Room(good, bad, ex, good2);

        }
    }
}
