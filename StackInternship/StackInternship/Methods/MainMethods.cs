using System;
using System.Linq;
using StackInternship.Data.Entities.Models;
using StackInternship.Domain.Factories;
using StackInternship.Domain.Repositories;
using StackInternship.Data.Entities.Enums;

namespace StackInternship.Presentation.Methods
{
    public class MainMethods
    {
        public static void UserInput()
        {
            PrintMethods.PrintLoginInput();

            var showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        public static bool MainMenu()
        { 
            switch (Console.ReadLine())
            {
                case "1":
                    RegisterInput();
                    return true;
                case "2":
                    LoginInput();
                    return true;
                case "3":
                    Console.WriteLine("Izašli ste iz aplikacije. Doviđenja!");
                    return false;
                default:
                    return true;
            }
        }

        private static void RegisterInput()
        {
            var userName = ValidateMethods.NameInputRegistration();

            var password = ValidateMethods.PasswordInput();

            var newUser = new User(userName, password);

            RepositoryFactory.Create<UserRepository>().Add(newUser);

            DashboardMenu(userName);
        }

        private static void LoginInput()
        {
            var userName = ValidateMethods.NameInput();

            var password = ValidateMethods.PasswordInput();

            DashboardMenu(userName);
        }

        private static void DashboardMenu(string userName)
        {
            PrintMethods.PrintMenu();

            switch (Console.ReadLine())
            {
                case "1":
                    ChooseAreaMenu(userName);
                    break;
                case "2":
                    Users();
                    break;
                case "3":
                    ChooseAreaMenuUnanswered();
                    break;
                case "4":
                    Popular();
                    break;
                case "5":
                    MyProfile(userName);
                    break;
                default:
                    break;
            }
        }

        private static void ChooseAreaMenu(string userName)
        {
            PrintMethods.AreaMenu();
            
            switch (Console.ReadLine())
            {   

                case "1":
                    PublishedResources(Area.Dev, userName);
                    break;
                case "2":
                    PublishedResources(Area.Dizajn, userName);
                    break;
                case "3":
                    PublishedResources(Area.Marketing, userName);
                    break;
                case "4":
                    PublishedResources(Area.Multimedija, userName);
                    break;
                case "5":
                    PublishedResources(Area.Generalno, userName);
                    break;
            }
        }

        private static void PublishedResources(Area chosenArea, string userName)
        {   
            Console.Clear();

            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Resources
                .Where(c => c.Area == chosenArea)
                .ToList()
                .ForEach(c => {
                    Console.Write($"ID: {c.Id} " +
                        $" Sadržaj: {c.Content} " +
                        $" Datum objave: {c.DateOfPublication} " +
                        $" Autor: {c.UserId} " +
                        $" Područje: {c.Area} " + 
                        $" UpVote: {c.UpVote} " +
                        $" DownVote: {c.DownVote} " +
                        $" Komentari: {c.Comments}\n");
                });
            CommentMethods.ChooseCommentActionMenu(userName);
        }

        private static void Users()
        {
            PrintMethods.UserSelectionMenu();

            switch (Console.ReadLine())
            {

                case "1":
                    ChoosePrintUsersByArea();
                    break;
                case "2":
                    ChoosePrintUsersByRole();
                    break;
            }
        }

        private static void ChoosePrintUsersByArea()
        {
            PrintMethods.AreaMenu();

            switch (Console.ReadLine())
            {

                case "1":
                    PrintUsers(Area.Dev);
                    break;
                case "2":
                    PrintUsers(Area.Dizajn);
                    break;
                case "3":
                    PrintUsers(Area.Marketing);
                    break;
                case "4":
                    PrintUsers(Area.Multimedija);
                    break;
                case "5":
                    PrintUsers(Area.Generalno);
                    break;
            }
        }

        private static void ChoosePrintUsersByRole()
        {
            PrintMethods.AreaMenu();

            switch (Console.ReadLine())
            {

                case "1":
                    PrintUsersByRole(UserRole.Organizator);
                    break;
                case "2":
                    PrintUsersByRole(UserRole.Intern);
                    break;
            }
        }

        private static void PrintUsers(Area chosenArea)
        {
            Console.Clear();
            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Users
                .Where(c => c.Area == chosenArea)
                .ToList()
                .ForEach(c => {
                    Console.Write($"Korisničko ime: {c.UserName} " +
                        $" Reputacijski bodovi: {c.ReputationPoints} " +
                        $" Uloga: {c.UserRole} " +
                        $" Trusted user: {c.ReputationalPrivilege} " +
                        $" Status računa: {c.AccountStatus}\n");
                });
        }

        private static void PrintUsersByRole(UserRole userRole)
        {
            Console.Clear();
            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Users
                .Where(c => c.UserRole == userRole)
                .ToList()
                .ForEach(c => {
                    Console.Write($"Korisničko ime: {c.UserName} " +
                        $" Reputacijski bodovi: {c.ReputationPoints} " +
                        $" Uloga: {c.UserRole} " +
                        $" Trusted user: {c.ReputationalPrivilege} " +
                        $" Status računa: {c.AccountStatus}\n");
                });
        }

        private static void ChooseAreaMenuUnanswered()
        {
            PrintMethods.AreaMenu();

            switch (Console.ReadLine())
            {

                case "1":
                    Unanswered(Area.Dev);
                    break;
                case "2":
                    Unanswered(Area.Dizajn);
                    break;
                case "3":
                    Unanswered(Area.Marketing);
                    break;
                case "4":
                    Unanswered(Area.Multimedija);
                    break;
                case "5":
                    Unanswered(Area.Generalno);
                    break;
            }
        }

        private static void Unanswered(Area chosenArea)
        {
            Console.Clear();
            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Resources
                .Where(c => c.Area == chosenArea)
                .Where(c => c.Comments == null)
                .ToList()
                .ForEach(c => {
                    Console.Write($"ID: {c.Id} " +
                        $" Sadržaj: {c.Content} " +
                        $" Datum objave: {c.DateOfPublication} " +
                        $" Autor: {c.UserId} " +
                        $" Područje: {c.Area} " +
                        $" UpVote: {c.UpVote} " +
                        $" DownVote: {c.DownVote} " +
                        $" Komentari: {c.Comments}\n");
                });
        }

        private static void Popular()
        {
            Console.Clear();
            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Resources
                .OrderByDescending(c => c.Comments.Count())
                .Take(5)
                .ToList()
                .ForEach(c => {
                    Console.Write($"ID: {c.Id} " +
                        $" Sadržaj: {c.Content} " +
                        $" Datum objave: {c.DateOfPublication} " +
                        $" Autor: {c.UserId} " +
                        $" Područje: {c.Area} " +
                        $" UpVote: {c.UpVote} " +
                        $" DownVote: {c.DownVote} " +
                        $" Komentari: {c.Comments}\n");
                });
        }

        private static void MyProfile(string userName)
        {
            Console.Clear();
            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Users
                .Where(c => c.UserName == userName)
                .ToList()
                .ForEach(c => {
                    Console.Write($"Korisničko ime: {c.UserName} " +
                        $" Reputacijski bodovi: {c.ReputationPoints} " +
                        $" Uloga: {c.UserRole} " +
                        $" Trusted user: {c.ReputationalPrivilege} " +
                        $" Status računa: {c.AccountStatus}\n");
                });

            PrintMethods.EditUserMenu();

            switch (Console.ReadLine())
            {

                case "1":
                    EditUserName(userName);
                    break;
                case "2":
                    EditPassword(userName);
                    break;
                case "3":
                    break;
            }
        }

        private static void EditUserName(string userName)
        {
            Console.Clear();

            var password = ValidateMethods.PasswordInput();

            var newUserName = ValidateMethods.NameInput();

            /*var context = DbContextFactory.GetStackInternshipDbContext();
            context.Users
                .Where(c => c.UserName == userName)
                .ToList()
                .ForEach(c => {
                    c.UserName = newUserName;
                });*/

            Console.WriteLine("\r\nUnesite ID: ");
            var idComment = Console.ReadLine();

            int id = Convert.ToInt32(idComment);

            var newUser = new User(newUserName, password);

            RepositoryFactory.Create<UserRepository>().Edit(newUser, id);
        }

        private static void EditPassword(string userName)
        {
            Console.Clear();

            var password = ValidateMethods.PasswordInput();

            var newPassword = ValidateMethods.PasswordInput();

            /*var context = DbContextFactory.GetStackInternshipDbContext();
            context.Users
                .Where(c => c.UserName == userName)
                .ToList()
                .ForEach(c => {
                    c.Password = newPassword;
                });*/

            Console.WriteLine("\r\nUnesite ID: ");
            var idComment = Console.ReadLine();

            int id = Convert.ToInt32(idComment);

            var newUser = new User(userName, newPassword);

            RepositoryFactory.Create<UserRepository>().Edit(newUser, id);
        }

    }
}
