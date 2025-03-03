using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class LibraryLogic
    {

       public static List<BookModel> ReturnBook(MemberModel member, List<BookModel> books, string returnBook)
        {
            // Ask the user to enter the title of the book they want to return
            Console.Write("Enter the title of the book you want to return: ");
            returnBook = Console.ReadLine().Trim();

            for (int i = 0; i < member.BorrowedBooks.Count; i++)
            {
              var book = member.BorrowedBooks[i];
                // Check if the book is in the library
                if (book.Title.ToLower().Trim() == returnBook)
                {
                    // start the return process
                    Console.WriteLine($"You returned {book.Title}");
                    book.IsAvailable = true;
                    member.BorrowedBooks.RemoveAt(i);
                    books.Add(book);
                    return books;

                }
            }
            
            //If the book is not in the library, display a message
            Console.WriteLine("The book is not in the library");
            return books;
        }

        public static List<BookModel> BorrowBook(List<BookModel> books, string borrowBook, MemberModel member)
        {
            // Ask the user to enter the title of the book they want to borrow
            Console.Write("Enter the title of the book you want to borrow(or type 'exit'): ");
            borrowBook = Console.ReadLine().Trim();

            for (int i = 0; i < books.Count; i++)
            {
                var book = books[i]; 
                // If the book is in the library and is available, start the borrowing process
                if (book.Title.ToLower().Trim() == borrowBook && book.IsAvailable)
                {
                    Console.WriteLine($"You borrowed {book.Title}");
                    book.IsAvailable = false;
                    books.RemoveAt(i);
                    member.BorrowedBooks.Add(book);
                    return books;
                }

            }
           

            Console.WriteLine("The book is not in the library or is not available");
            return books;

        }

        public static void DisplayBooks(List<BookModel> books)
        {
            Console.Write("Available Books:");
            foreach (var book in books)
            {
                if (book.IsAvailable)
                {
                    Console.WriteLine($"{book.Title} By {book.Author} ");
                }
            }
            Console.WriteLine();
        }

        public static void DisplayBorrowedBooks(MemberModel member)
        {
            Console.WriteLine("\nBorrowed Book(s):");
            foreach (var book in member.BorrowedBooks)
            {
                Console.WriteLine($"{book.Title}");
            }
            if(member.BorrowedBooks.Count == 0)
            {
                Console.WriteLine("You have no books");
            }
            Console.WriteLine();
        }

        public static void UserChoice(List<BookModel> books, MemberModel member)
        {
            string userInput;
            


            do
            {
                Console.Write("Enter 'borrow' or 'return' to a book(or type 'exit' to quit): ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    DisplayBorrowedBooks(member);
                    UserMessages.GoodbyeMessage();

                    break;
                }
                else if (userInput.ToLower() == "borrow")
                {
                    BorrowBook(books, userInput, member);
                    DisplayBorrowedBooks(member);

                }
                else if (userInput.ToLower() == "return")
                {
                    ReturnBook(member, books, userInput);
                    DisplayBorrowedBooks(member);


                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            while (userInput.ToLower() != "exit");
        }

    }
}
