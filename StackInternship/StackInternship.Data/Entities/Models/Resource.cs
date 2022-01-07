using System;
using System.Collections.Generic;
using StackInternship.Data.Entities.Enums;

namespace StackInternship.Data.Entities.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DateOfPublication { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Area Area { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
