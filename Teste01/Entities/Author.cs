namespace Teste01.Entities
{
    public class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Author(string name, string email)
        {
            Name = name;
            Email = email;
        }
        
    }
}