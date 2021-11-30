using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibraryStandard
{
    public class Printer
    {

        public void Print(string[] inInput)
        {
            foreach (var item in inInput)
            {
                Console.WriteLine(item);
            }                  
        }

    }
}
