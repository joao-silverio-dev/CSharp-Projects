using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03.Entities
{
    public class Post
    {
        public DateTime Date = new DateTime();
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments = new List<Comment>();

        public Post(string title, string content, int likes, DateTime date)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment comment in Comments)
            {
                sb.AppendLine(comment.Text);
            }

            return sb.ToString();
        }
    }
}