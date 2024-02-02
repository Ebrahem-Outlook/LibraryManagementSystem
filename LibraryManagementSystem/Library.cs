using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem
{
    internal class Library
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        public void AddBook(String _Title, String _Author)
        {
            books.Add(new Book { Title = _Title, Author = _Author });
        }

        public void AddMember(String _Name, int _Id)
        {
            members.Add(new Member { Name = _Name, Id = _Id });
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Avaliable Books: ");

            foreach (var book in books)
            {
                if(book.IsAvailable)
                    Console.WriteLine($"{book.Title} by {book.Author}");
            }
        }

        public void BorrowBook(String title)
        {
            foreach(var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && book.IsAvailable)
                {
                    book.IsAvailable = false;
                    Console.WriteLine($"book {title} has been returned.");
                    return;
                }
            }
            Console.WriteLine("Book not found or already returned.");
        }

        public void ReturnBook(String title)
        {
            foreach(var book in books)
            {
                if(book.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && !book.IsAvailable)
                {
                    book.IsAvailable = true;
                    Console.WriteLine($"Book '{title}' has been returned.");
                    return;
                }
            }
            Console.WriteLine("Book not found or already returned.");
        }
    }
}



