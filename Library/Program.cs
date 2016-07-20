using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Insert Author, please");
            string name = Console.ReadLine();
            
            Console.WriteLine(Environment.NewLine + "Insert Title, please");
            string title = Console.ReadLine();

            Console.WriteLine("\nInsert Content, please");
            string content = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Beep();

            Book book = new Book(name, title, content);
            book.Show();
            Console.ReadKey();
        }
    }
}
