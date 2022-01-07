using System.Collections.Generic;
using StackInternship.Data.Entities.Enums;

namespace StackInternship.Data.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Area Area { get; set; }
        public int ReputationPoints { get; set; }
        public UserRole UserRole { get; set; }
        public ReputationalPrivilege ReputationalPrivilege { get; set; }
        public AccountStatus AccountStatus { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<Resource> Resources { get; set; }

        public User()
        { 
        }

        public User(string name, string password)
        {

            UserName = name;
            Password = password;
            ReputationPoints = 1;
            ReputationalPrivilege = ReputationalPrivilege.None;
            AccountStatus = AccountStatus.Aktivan;
        }
    }
}
