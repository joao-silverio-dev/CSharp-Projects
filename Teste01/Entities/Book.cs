using System;

namespace Teste01.Entities
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public double Price { get; set; }

        public Book(string title, Author author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"\nBook's Info \n\nTitle: {Title}\n" +
                              $"Author's Name: {Author.Name}\n" +
                              $"Author's Email: {Author.Email}\n" +
                              $"Price: {Price}");
        }
    }
}