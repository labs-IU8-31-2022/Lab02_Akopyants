using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Expert_Document_Worker : Document_Worker
    {
        public override void Open_Document()
        {
            base.Open_Document();
        }
        public override void Edit_Document()
        {
            base.Edit_Document();
        }
        public override void Save_Document()
        {
            Console.WriteLine("The document is saved in a new format\n");
        }
    }
}
