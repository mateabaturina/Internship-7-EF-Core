﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackInternship.Data.Entities.Models
{
    public class Comment
    {
        public DateTime DateOfPublication { get; set; }
        public string UserName { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
    }
}