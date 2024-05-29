using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Mini_Project.ManageOOP
{
    public class Book : Item
    {
        public Book(int id, string title) : base(id, title)
        {

        }

        public override void DisplayName()
        {
            Console.WriteLine($"Id name is : {Id} , Name is : {Title}");
        }
    }
}
