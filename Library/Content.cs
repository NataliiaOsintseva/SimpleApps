using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Content {

        private string source;

        public Content(string val) {
            this.source = val;
        }

        public void Show() {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Content <{0}>", source);
        }
    }
}
