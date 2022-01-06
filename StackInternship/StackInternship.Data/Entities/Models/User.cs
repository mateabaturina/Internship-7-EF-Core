using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackInternship.Data.Entities.Enums;

namespace StackInternship.Data.Entities.Models
{
    public class User
    {
        public string UserName { get; set; }
        public int ReputationPoints { get; set; }
        public UserRole UserRole { get; set; }
        public ReputationalPrivilege ReputationalPrivilege { get; set; }
    }
}
