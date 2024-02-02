using LibraryManagementSystem;
using Microsoft.Win32.SafeHandles;

namespace LibraryMangementSystem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Library library = new Library();

            library.AddBook("The Great Gatsby", "F. Scott Fitzgerald");
            library.AddBook("To Kill a Mockingbird", "Harper Lee");
            library.AddBook("1984", "George Orwell");

            library.AddMember("John Doe", 101);
            library.AddMember("Jane Smith", 102);

            while (true)
            {
                Console.WriteLine("\n1. Display Available Books");
                Console.WriteLine("2. Borrow a Book");
                Console.WriteLine("3. Return a Book");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            library.DisplayBooks();
                            break;
                        case 2:
                            Console.Write("Enter the title of the book you want to borrow: ");
                            string borrowTitle = Console.ReadLine();
                            Console.Write("Enter your member ID: ");
                            int memberId = Convert.ToInt32(Console.ReadLine());
                            library.BorrowBook(borrowTitle);
                            break;
                        case 3:
                            Console.Write("Enter the title of the book you want to return: ");
                            string returnTitle = Console.ReadLine();
                            library.ReturnBook(returnTitle);
                            break;
                        case 4:
                            Console.WriteLine("Exiting...");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                }
            }


        }
    }
}
