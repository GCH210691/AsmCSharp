using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            Librarian lb = new Librarian();
            Teacher teacher = new Teacher();
            Student student = new Student();
            int choose = 0;

            do
            {
                Console.WriteLine("---Library managing system---");
                Console.WriteLine("1. Admin\n2. Labrarian\n3. Teacher/Student\n4. Exit");
                Console.WriteLine("Input your command: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        if (LoginAdmin() == true)
                        {
                            int aChoice = 0;
                            Console.WriteLine("---Admin display---");
                            do
                            {
                                Console.WriteLine("1. Add new teacher\n2. Add new student\n3. Add new Libraran\n4. show all users");
                                Console.WriteLine("Input your choice");
                                aChoice = Convert.ToInt32(Console.ReadLine());
                                switch (aChoice)
                                {
                                    case 1:
                                        teacher.AddUser();
                                        break;
                                    case 2:
                                        student.AddUser();
                                        break;
                                    case 3:
                                        lb.AddUser();
                                        break;
                                    case 4:
                                        Console.WriteLine("Teachers infomation: ");
                                        teacher.ShowUser();
                                        Console.WriteLine("Students infomation: ");
                                        student.ShowUser();
                                        Console.WriteLine("Librarians infomation: ");
                                        lb.ShowUser();
                                        break;
                                }
                            } while (aChoice != 5);
                        }
                        else
                        {
                            Console.WriteLine("login failed.");
                            break;
                        }
                        break;
                    case 2:
                        int bChoice = 0;
                        do
                        {
                            Console.WriteLine("---Librarian display---");
                            Console.WriteLine("1. Add book\n2. Show all book\n3. Delete book\n4. Search with name\n5. Search with Id\n6. Edit book\n7. Back to Menu");
                            Console.WriteLine("Input your choice");
                            bChoice = Convert.ToInt32(Console.ReadLine());
                            switch (bChoice)
                            {
                                case 1:
                                    lb.AddBook();
                                    break;
                                case 2:
                                    lb.PrintBook();
                                    break;
                                case 3:
                                    Console.WriteLine("Input book Id to delete: ");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    lb.DeleteBook(id);
                                    break;
                                case 4:
                                    Console.WriteLine("Input book name to search: ");
                                    string name = Console.ReadLine();
                                    lb.Search(name);
                                    break;
                                case 5:
                                    Console.WriteLine("Input book id to search: ");
                                    int sid = Convert.ToInt32(Console.ReadLine());
                                    lb.Search(sid);
                                    break;
                                case 6:
                                    Console.WriteLine("input book id to update: ");
                                    int uid = Convert.ToInt32(Console.ReadLine());
                                    lb.EditBook(uid);
                                    break;
                            }
                        }
                        while (bChoice != 7);
                        break;
                    case 3:
                        int cChoice = 0;
                        do
                        {
                            Console.WriteLine("---Teacher/Student display---");
                            Console.WriteLine("1. View all books\n2. Search with name\n3. Search with Id\n4. Borrow book\n5. Back to Menu");
                            Console.WriteLine("Input your choice");
                            cChoice = Convert.ToInt32(Console.ReadLine());
                            switch (cChoice)
                            {
                                case 1:
                                    lb.PrintBook();
                                    break;
                                case 2:
                                    Console.WriteLine("Input book name to search: ");
                                    string name = Console.ReadLine();
                                    lb.Search(name);
                                    break;
                                case 3:
                                    Console.WriteLine("Input book Id to search: ");
                                    int sid = Convert.ToInt32(Console.ReadLine());
                                    lb.Search(sid);
                                    break;
                                case 4:
                                    Console.WriteLine("Input book Id to borrow: ");
                                    int bid = Convert.ToInt32(Console.ReadLine());
                                    lb.BorrowBook(bid);
                                    break;
                            }
                        } while (cChoice != 5);
                        break;

                }
            } while (choose != 5);
            

            bool LoginAdmin()
            {
                bool a = false;
                Console.Write("Input Username: ");
                string username = Console.ReadLine();
                Console.Write("input password: ");
                string password = "";
                ConsoleKeyInfo keyInfo;
                do
                {
                    keyInfo = Console.ReadKey(true);
                    //Skip if backspace or enter is pressed
                    if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                    {
                        password += keyInfo.KeyChar;
                        Console.Write("*");
                    }
                }
                //stop getting password when the Enter is pressed
                while (keyInfo.Key != ConsoleKey.Enter);
                    Console.WriteLine();
                if (username == "admin" && password == "admin")
                {
                    return a = true;
                }
                return a;

            }
        }
        
        
    }

}
