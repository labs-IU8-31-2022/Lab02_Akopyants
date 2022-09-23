using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_Akopyants
{
    class Class_Room
    {
        public Class_Room(params Pupil[] arguments)
        {
            Pupils = new List<Pupil>();
            foreach (var elem in arguments) 
            {
                Pupils.Add(elem);
                elem.Study();
                elem.Relax();
                elem.Read();
                elem.Write();
            }
        }
        private List<Pupil> Pupils;
    }
}
