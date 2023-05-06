using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm
{
    internal class Book
    {
        private int id;
        private string name; 
        private int price;
        private string author;

        public Book(int id, string name, int price, string author)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.author = author;
        }
        public Book()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                author = value;
            }
        }
        public string printBook()
        {
            return "Book ID: " + id + "\n Book Name: " + name + " \n Book Price: " + price + " \n Book Author: " + author;
        }
    }
}
