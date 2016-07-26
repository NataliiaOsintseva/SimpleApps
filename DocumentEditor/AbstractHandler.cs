using System;

namespace DocumentEditor
{
    abstract class AbstractHandler
    {
        protected string fileName;

        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        public void Open()
        {
            Console.WriteLine(fileName + " opened");
        }

        public void Create()
        {
            Console.WriteLine(fileName + " created");
        }

        // Imagine they are edited in a different way
        public abstract void Change();

        public void Save()
        {
            Console.WriteLine(fileName + " edited");
        }
    }

    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Change()
        {
            Console.WriteLine(fileName + " changed an .xml file");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Change()
        {
            Console.WriteLine(fileName + " changed a .txt file");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Change()
        {
            Console.WriteLine(fileName + " changed a .doc file");
        }
    }
}
