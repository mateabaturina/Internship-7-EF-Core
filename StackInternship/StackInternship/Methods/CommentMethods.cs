using StackInternship.Data.Entities.Models;
using StackInternship.Domain.Factories;
using StackInternship.Domain.Repositories;
using System;
using System.Linq;

namespace StackInternship.Presentation.Methods
{
    public class CommentMethods
    {
        public static void ChooseCommentActionMenu(string userName)
        {
            PrintMethods.EditCommentMenu();

            var count = CheckingPrivileges.CheckingReputationPoints(userName);

            switch (Console.ReadLine())
            {

                case "1":
                    if (count >= 5)
                        UpVoteComment();

                    else
                    {
                        Console.WriteLine("Nemoguće je obaviti željenu radnju! Imate premalo bodova.");
                        Console.ReadLine();
                    }

                    break;

                case "2":
                    if (count >= 20)
                        DownVoteComment();

                    else
                    {
                        Console.WriteLine("Nemoguće je obaviti željenu radnju! Imate premalo bodova.");
                        Console.ReadLine();
                    }

                    break;

                case "3":
                    if (count >= 100)
                        EditComment();

                    else
                    {
                        Console.WriteLine("Nemoguće je obaviti željenu radnju! Imate premalo bodova.");
                        Console.ReadLine();
                    }
                    break;

                case "4":
                    if (count >= 500)
                        DeleteComment();

                    else
                    {
                        Console.WriteLine("Nemoguće je obaviti željenu radnju! Imate premalo bodova.");
                        Console.ReadLine();
                    }
                    break;

                case "5":
                    if (count >= 1)
                        CreateNewComment();

                    else
                    {
                        Console.WriteLine("Nemoguće je obaviti željenu radnju! Imate premalo bodova.");
                        Console.ReadLine();
                    }
                    break;

                case "6":
                    break;
            }
        }

        public static void UpVoteComment()
        {
            Console.WriteLine("\r\nUnesite ID komentara: ");
            var idComment = Console.ReadLine();

            int id = Convert.ToInt32(idComment);

            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Comments
                .Where(c => c.Id == id)
                .ToList()
                .ForEach(c => {
                    c.UpVote += 1;
                });
        }

        public static void DownVoteComment()
        {
            Console.WriteLine("\r\nUnesite ID komentara: ");
            var idComment = Console.ReadLine();

            int id = Convert.ToInt32(idComment);

            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Comments
                .Where(c => c.Id == id)
                .ToList()
                .ForEach(c => {
                    c.DownVote -= 1;
                });
        }

        public static void EditComment()
        {
            Console.WriteLine("\r\nUnesite ID komentara: ");
            var idComment = Console.ReadLine();

            int id = Convert.ToInt32(idComment);

            Console.WriteLine("\r\nUnesite ID komentara: ");
            var newText = Console.ReadLine();

            var context = DbContextFactory.GetStackInternshipDbContext();
            context.Comments
                .Where(c => c.Id == id)
                .ToList()
                .ForEach(c => {
                    c.Text = newText;
                });
        }

        public static void DeleteComment()
        {
            Console.WriteLine("\r\nUnesite ID komentara: ");
            var idComment = Console.ReadLine();

            int id = Convert.ToInt32(idComment);

            RepositoryFactory.Create<CommentRepository>().Delete(id);
        }

        public static void CreateNewComment()
        {
            var text = ValidateMethods.TextInput();

            Console.WriteLine("\r\nUnesite ID objave: ");
            var idComment = Console.ReadLine();

            int id = Convert.ToInt32(idComment);

            var newComment = new Comment(text, id);

            RepositoryFactory.Create<CommentRepository>().Add(newComment);
        }
    }
}
