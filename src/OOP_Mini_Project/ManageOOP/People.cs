using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Mini_Project.ManageOOP
{
    //base class
    public abstract class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public People(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void DisplayName();

        public virtual void NameVirtual()
        {
            Console.WriteLine($"It is from virtual, base clas : {Name}");
        }

        public void NameBaseClass()
        {
            Console.WriteLine($"It is from local method , base class : {Name}");
        }
    }
}
