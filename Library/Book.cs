using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private Author author;
        private Title title;
        private Content content;

        public Book(string name, string header, string source) {
            this.author = new Author(name);
            this.title = new Title(header);
            this.content = new Content(source);
        }

        public void Show() {
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
