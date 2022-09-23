using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Pro_Document_Worker : Document_Worker
    {
        public override void Open_Document()
        {
            base.Open_Document();
        }
        public override void Edit_Document()
        {
            Console.WriteLine("The document has been edited\n");
        }
        public override void Save_Document()
        {
            Console.WriteLine("The document is saved in the old format saving in other formats is available in the expert version\n");
        }
    }
}
