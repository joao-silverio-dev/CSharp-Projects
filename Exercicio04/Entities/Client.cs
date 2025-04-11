using System;
namespace Exercicio04.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Client Name: {Name}\n" +
                   $"Client Email: {Email}\n" +
                   $"Client Birth Date: {BirthDate}";
        }
        
    }
}