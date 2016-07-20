using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docs
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker docWorker = null;

            Console.WriteLine("Введите ключ доступа");
            string isKey = Console.ReadLine();
            switch (isKey) {
                case "pro101010":
                    docWorker = new ProDocumentWorker();
                    Console.WriteLine("Pro version is available");
                    break;
                case "exp202020":
                    docWorker = new ExpertDocumentWorker();
                    Console.WriteLine("Expert version is available");
                    break;
                default:
                    docWorker = new DocumentWorker();
                    Console.WriteLine("Free version is available");
                    break;
            }

                docWorker.OpenDocument();
                docWorker.EditDocument();
                docWorker.SaveDocument();
                Console.ReadKey();
            
        }
    }
}
