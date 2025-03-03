using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // Create Library 
            List<BookModel> books = new List<BookModel>();
            // Add books to the library
            books.Add(new BookModel { 
                Title = "the great gatsby",
                Author = "F. Scott Fitzgerald",
                ISBN = "9780743273565",
                IsAvailable = true 
            });
            books.Add(new BookModel
            {
                Title = "to kill a mockingbird",
                Author = "Harper Lee",
                ISBN = "9780061120084",
                IsAvailable = true
            });

            books.Add(new BookModel
            {
                Title = "1984",
                Author = "George Orwell",
                ISBN = "9780451524935",
                IsAvailable = true
            });

            books.Add(new BookModel
            {
                Title = "pride and prejudice",
                Author = "Jane Austen",
                ISBN = "9780679783268",
                IsAvailable = true
            });

            books.Add(new BookModel
            {
                Title = "The Catcher in the Rye",
                Author = "J.D. Salinger",
                ISBN = "9780316769488",
                IsAvailable = true
            });

            // Create Members
            MemberModel member = new MemberModel();
            member.Name = "Marc";
            member.MemberID = "1234";
            member.BorrowedBooks = new List<BookModel>();


            // WelcomeMessage
            UserMessages.WelcomeMessage();

            // Display Available Books
            LibraryLogic.DisplayBooks(books);

    
            //User Choices
            LibraryLogic.UserChoice(books, member);


            Console.ReadLine(); 
        }
    }
}
