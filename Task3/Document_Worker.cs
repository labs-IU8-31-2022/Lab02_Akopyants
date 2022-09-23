using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Document_Worker
    {
        public Document_Worker() { }


        public virtual void Open_Document() { Console.WriteLine("Document open\n"); }
        public virtual void Edit_Document() { Console.WriteLine("Document editing is available in the pro version\n"); }
        public virtual void Save_Document() { Console.WriteLine("Document saving is available in the mode\n"); }
    }
}
