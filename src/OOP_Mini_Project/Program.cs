using OOP_Mini_Project.ManageOOP;

namespace OOP_Mini_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book(1, "Book no: 1");
            Book book2 = new Book(2, "Book no: 2");
            Book book3 = new Book(3, "Book no: 3");

            BookShelf bookShelf1 = new BookShelf(1, "Bookshelf no: 1");
            BookShelf bookShelf2 = new BookShelf(2, "Bookshelf no: 2");

            library.AddItems(book1);
            library.AddItems(book2);
            library.AddItems(book3);

            library.AddItems(bookShelf1);

            //people-->base class
            Member member1 = new Member(1, "Member no: 1");
            Member member2 = new Member(2, "Member no: 2");

            library.AddPeoples(member1);
            library.AddPeoples(member2);

            Librarian librarian = new Librarian(1, "Sakhawat");
            library.AddPeoples(librarian);

            library.ShowPeopleInLibrary();
            library.ShowItemsInLibrary();
        }
    }
}
