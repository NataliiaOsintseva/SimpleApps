﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentEditor
{
    class Editor
    {
        AbstractHandler handler;

        public void ChooseDocument(string fileName)
        {
            string format = fileName.Substring(fileName.Length - 4);

            switch (format.ToLower())
            {
                case ".txt":
                    handler = new TXTHandler(fileName);
                    break;
                case ".doc":
                    handler = new DOCHandler(fileName);
                    break;
                case ".xml":
                    handler = new XMLHandler(fileName);
                    break;
                default:
                    Console.WriteLine("I can't handle that unknown format");
                    break;
            }
        }

        public void Open()
        {
            handler.Open();
        }

        public void Craete()
        {
            handler.Create();
        }

        public void Change()
        {
            handler.Change();
        }

        public void Save()
        {
            handler.Save();
        }
    }
}
