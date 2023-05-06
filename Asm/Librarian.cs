using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm
{
    internal class Librarian : ProgramUser
    {
        public Librarian(int id, string name, int phone) : base(id, name, phone)
        {
            //subclass constructor
        }

        public Librarian() 
        {
            //constructor with non parameters
        }
        List<Book> ListBook = new List<Book>();
        public void Search(string name)
        {
            foreach (Book a in ListBook) 
            {
                if (a.Name == name)
                {
                    Console.WriteLine(a.printBook());
                }
            }
        }

        public void Search(int id)
        {
            foreach (Book a in ListBook)
            {
                if (a.Id == id)
                {
                    Console.WriteLine(a.printBook());
                }
            }
        }
        public void AddBook()
        {
            Console.Write("input book Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Book's name: ");
            string name = Console.ReadLine();
            Console.Write("input price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Author: ");
            string author = Console.ReadLine();

            ListBook.Add(new Book(id, name, price, author));
        }
        public void PrintBook()
        {
            foreach(Book b in ListBook)
            {
                Console.WriteLine(b.printBook());
            }
        }
        public void DeleteBook(int id)
        {
            foreach (Book b in ListBook)
            {
                if (b.Id == id)
                {
                    Console.WriteLine("the book" + b.Name + "has been deleted.");
                    ListBook.Remove(b);
                    break;
                }
            }
        }
        public void EditBook(int id)
        {
            foreach (Book b in ListBook)
            {
                if(b.Id == id)
                {
                    Console.WriteLine("---edit book---");
                    Console.WriteLine("Book Id: " + id);
                    Console.Write("Book name: ");
                    string name = Console.ReadLine();
                    Console.Write("Book price: ");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Book author: ");
                    string author = Console.ReadLine();
                    Console.WriteLine("Edited.");
                    ListBook.Remove(b);
                    ListBook.Add(new Book(id, name, price, author));
                }
                else
                {
                    Console.WriteLine("Book not found!");
                }
            }
        }
        public void BorrowBook(int id)
        {
            foreach( Book b in ListBook)
            {
                if(b.Id == id)
                {
                    Console.WriteLine(b.printBook());
                    Console.Write("Do you want to borrow this book? (Y/N): ");
                    string rel = Console.ReadLine();
                    if (rel == "Y")
                    {
                        Console.WriteLine("Book borowed at " + DateTime.Now + ". Please return the book at " + DateTime.Now.AddDays(2));
                    }
                    else if (rel == "N")
                    {
                        Console.WriteLine("Input book Id: ");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input.");
                    }
                }
                else { Console.WriteLine("Book is invalid in the library."); }
            }
        }
        public override void AddUser()
        {
            base.AddUser();
        }
        public override void ShowUser()
        {
            base.ShowUser();
        }
    }
    
}
