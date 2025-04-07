using System;
using Teste01.Entities;

namespace Teste01 //Composition Exercise
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Book's Info: ");
            Console.Write("Title: ");
            string bookTitle = Console.ReadLine();
            Console.Write("Price: ");
            double bookPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Author's Info: ");
            Console.Write("Name: ");
            string authorsName = Console.ReadLine();
            Console.Write("Email: ");
            string authorsEmail = Console.ReadLine();

            Author author = new Author(authorsName, authorsEmail);
            Book book = new Book(bookTitle, author, bookPrice);

            book.ShowDetails();

        }
    }
}