using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackInternship.Data.Entities.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateOfPublication { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public int CommentId { get; set; }
        public Comment Comment{ get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
