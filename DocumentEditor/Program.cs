﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor();
            editor.ChooseDocument("mySuperFile.XML");

            editor.Open();
            editor.Change();
            editor.Save();

            Console.ReadKey();
        }
    }
}
