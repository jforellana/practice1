﻿using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    internal class PrintStuff
    {
        private string language;

        public PrintStuff()
        {
            language = "EN";
        }
        public PrintStuff(string temp)
        {
            language = temp;
        }
        public void PrintName(string n)
        {

            if (language == "EN")
            {
                System.Console.WriteLine("Hello " + n);
            }
            
            if (language == "SPA")
            {
                System.Console.WriteLine("Hola " + n);
            }
        }
    }
}
