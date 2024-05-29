using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Mini_Project.ManageOOP
{
    public class Librarian : People
    {
        public Librarian(int id, string name) : base(id, name)
        {
        }

        public override void DisplayName()
        {
            Console.WriteLine($"This is from child class, librarian, id is {Id}, name is {Name}");
        }

        public override void NameVirtual()
        {
            Console.WriteLine($"This is from override virtual {Name}, id: {Id}");
        }
    }
}
