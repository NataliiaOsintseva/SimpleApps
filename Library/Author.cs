using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Author {

        private string authorVal;

        public Author(string val) {
            this.authorVal = val;
        }

        public void Show() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Author <{0}>", authorVal);
        }

    }
}
