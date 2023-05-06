using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm
{
    internal class ProgramUser
    {
        private int id;
        private string name;
        private int phone;

        public ProgramUser(int id, string name, int phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
        }
        public ProgramUser()
        {

        }
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Phone
        {
            get { return phone; }
        }
        public virtual void AddUser()
        {
            Console.WriteLine("input id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input name: ");
            name = Console.ReadLine();
            Console.WriteLine("input phone: ");
            phone = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void ShowUser() 
        {
            Console.WriteLine("Id: {0}\nName: {1}\nPhone: {2}", id, name, phone);
        }
    }
}
