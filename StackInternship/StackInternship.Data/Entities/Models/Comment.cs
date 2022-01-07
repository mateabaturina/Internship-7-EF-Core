using System;
using System.Collections.Generic;

namespace StackInternship.Data.Entities.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateOfPublication { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ResourceId { get; set; }
        public Resource Resource { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public Comment()
        {
        }

        public Comment(string text, int resourceId)
        {

            Text = text;
            ResourceId = resourceId;
            DateOfPublication = DateTime.Now;
            UpVote = 0;
            DownVote = 0;
        }
    }
}
