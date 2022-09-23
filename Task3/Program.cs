using System;

namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the key: (pro/exp)\n if you don't have a key, leave the field empty");
            string key = "";
            key = Console.ReadLine();
    
            if (key == "pro")
            {
                Pro_Document_Worker programm = new Pro_Document_Worker();
                programm.Open_Document();
                programm.Edit_Document();
                programm.Save_Document();
            }
            else if (key == "exp")
            {
                Expert_Document_Worker programm = new Expert_Document_Worker();
                programm.Open_Document();
                programm.Edit_Document();
                programm.Save_Document();
            }
            else if (key == "")
            {
                Document_Worker programm = new Document_Worker();
                programm.Open_Document();
                programm.Edit_Document();
                programm.Save_Document();
            }
            else
            {
                Console.WriteLine("Invalid key");
            }
        }
    }
}
