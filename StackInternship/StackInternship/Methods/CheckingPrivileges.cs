using StackInternship.Data.Entities.Enums;
using StackInternship.Domain.Factories;
using System.Linq;

namespace StackInternship.Presentation.Methods
{
    public class CheckingPrivileges
    {
        public static int CheckingReputationPoints(string userName)
        {
            var count = 0;

            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Users
                .Where(c => c.UserName == userName)
                .ToList()
                .ForEach(c => {
                    count += c.ReputationPoints;
                });

            return count;
        }

        public static void GettingTrustedUser(string userName)
        {
            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Users
                .Where(c => c.UserName == userName)
                .ToList()
                .ForEach(c => {
                    c.ReputationalPrivilege = ReputationalPrivilege.TrustedUser;
                });
        }

        public static void UpdatingTrustedUser(string userName)
        {
            var points = CheckingReputationPoints(userName);

            if (points == 1000)
                GettingTrustedUser(userName);

        }

        public static void BecomingOrganizer(string userName)
        {
            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Users
                .Where(c => c.UserName == userName)
                .ToList()
                .ForEach(c => {
                    c.UserRole = UserRole.Organizator;
                });
        }

        public static void UpdatingRole(string userName)
        {
            var points = CheckingReputationPoints(userName);

            if (points == 100000)
                BecomingOrganizer(userName);

        }

        /*public static UserRole CheckingIfOrganizer(string userName)
        {
            UserRole status;

            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Users
                .Where(c => c.UserName == userName)
                .ToList()
                .ForEach(c => {
                    if (context.Users.Any(c => c.UserName == userName))
                    {
                        status = UserRole.Organizator;
                    }

                    else
                        status = UserRole.Intern;

                    //return status;
                });

            return status;
        }*/
    }
}
