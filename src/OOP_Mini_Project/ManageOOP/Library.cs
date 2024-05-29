using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Mini_Project.ManageOOP
{
    public class Library
    {
        public List<Item> Items = new List<Item>();
        public List<People> Peoples = new List<People>();

        public void AddItems (Item items)
        {
            Items.Add(items);
            Console.WriteLine($"Item added successfully: {items.Title}");
        }

        public void AddPeoples (People peoples)
        {
            Peoples.Add(peoples);
            Console.WriteLine($"People added successfully: {peoples.Name}");
        }

        public void ShowItemsInLibrary()
        {
            Console.WriteLine("Item is started");
            foreach(Item item in Items)
            {
                Console.WriteLine($"Lists of Item: {item.Title}");
            }
            Console.WriteLine("Items End");
        }

        public void ShowPeopleInLibrary()
        {
            Console.WriteLine("People list is started");
            foreach (People people in Peoples)
            {
                Console.WriteLine($"Lists of People: {people.Name}");
            }
            Console.WriteLine("Peopls list End");

        }
    }
}
