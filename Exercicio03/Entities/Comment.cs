namespace Exercicio03.Entities
{
    public class Comment
    {
        public string Text { get; set; }
        public Comment(string text)
        {
            Text = text;
        }
    }
}