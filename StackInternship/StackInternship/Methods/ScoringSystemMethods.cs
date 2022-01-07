using StackInternship.Domain.Factories;
using System;
using System.Linq;

namespace StackInternship.Presentation.Methods
{
    public class ScoringSystemMethods
    {
        public static void AddPoints(string action, string userName)
        {
            switch (action)
            {

                case "UpVoteComment":
                    UpdateReputationPoints(userName, 10);
                    break;
                case "UpVoteAnswer":
                    UpdateReputationPoints(userName, 5);
                    break;
                case "GetUpVote":
                    UpdateReputationPoints(userName, 15);
                    break;
            }
        }

        private static void UpdateReputationPoints(string userName, int points)
        {
            Console.Clear();

            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Users
                .Where(c => c.UserName == userName)
                .ToList()
                .ForEach(c => {
                    c.ReputationPoints += points;
                });

            CheckingPrivileges.UpdatingTrustedUser(userName);
            CheckingPrivileges.UpdatingRole(userName);
        }

        public static void SubtractPoints(string action, string userName)
        {
            switch (action)
            {

                case "DownVoteComment":
                    UpdateReputationPoints(userName, -1);
                    break;
                case "DownVoteAnswer":
                    UpdateReputationPoints(userName, -2);
                    break;
                case "GetDownVote":
                    UpdateReputationPoints(userName, -3);
                    break;
            }
        }
    }
}
