using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Title {

        private string name;

        public Title(string val) {
            this.name = val;
        }

        public void Show() {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Title <{0}>", name);
        }

    }
}
