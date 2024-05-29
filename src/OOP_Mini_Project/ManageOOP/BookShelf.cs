using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Mini_Project.ManageOOP
{
    public class BookShelf : Item 
    {
        public BookShelf(int id, string title): base (id, title)
        {

        }
        public override void DisplayName()
        {
            Console.WriteLine($"Bookshelf id is {Id}, name is {Title}");
        }
    }
}
