using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StackInternship.Data.Entities.Enums;
using StackInternship.Data.Entities.Models;

namespace StackInternship.Data.Seeds
{
    public class DatabaseSeeder
    {
        public static void Execute(ModelBuilder builder)
        {

            builder.Entity<User>()
                .HasData(new List<User>
                {
                    new User
                    {
                        Id = 1,
                        UserName = "Harry",
                        Password = "Harry123",
                        Area = Area.Dev,
                        ReputationPoints = 5000,
                        UserRole = UserRole.Organizator,
                        ReputationalPrivilege = ReputationalPrivilege.TrustedUser,
                        AccountStatus = AccountStatus.Aktivan,
                    },

                    new User
                    {
                        Id = 2,
                        UserName = "Luna",
                        Password = "Luna123",
                        Area = Area.Dizajn,
                        ReputationPoints = 5000,
                        UserRole = UserRole.Organizator,
                        ReputationalPrivilege = ReputationalPrivilege.TrustedUser,
                        AccountStatus = AccountStatus.Aktivan,
                    },

                    new User
                    {
                        Id = 3,
                        UserName = "Hermione",
                        Password = "Hermione123",
                        Area = Area.Dev,
                        ReputationPoints = 100000,
                        UserRole = UserRole.Organizator,
                        ReputationalPrivilege = ReputationalPrivilege.TrustedUser,
                        AccountStatus = AccountStatus.Aktivan,
                    },

                    new User
                    {
                        Id = 4,
                        UserName = "Ron",
                        Password = "Ron123",
                        Area = Area.Multimedija,
                        ReputationPoints = 1000,
                        UserRole = UserRole.Organizator,
                        ReputationalPrivilege = ReputationalPrivilege.TrustedUser,
                        AccountStatus = AccountStatus.Aktivan,
                    },

                    new User
                    {
                        Id = 5,
                        UserName = "Draco",
                        Password = "Draco123",
                        Area = Area.Marketing,
                        ReputationPoints = 5000,
                        UserRole = UserRole.Organizator,
                        ReputationalPrivilege = ReputationalPrivilege.TrustedUser,
                        AccountStatus = AccountStatus.Aktivan,
                    },

                    new User
                    {
                        Id = 6,
                        UserName = "Fred",
                        Password = "Fred123",
                        Area = Area.Dev,
                        ReputationPoints = 100,
                        UserRole = UserRole.Intern,
                        ReputationalPrivilege = ReputationalPrivilege.None,
                        AccountStatus = AccountStatus.Aktivan,
                    },

                    new User
                    {
                        Id = 7,
                        UserName = "George",
                        Password = "George123",
                        Area = Area.Dev,
                        ReputationPoints = 100,
                        UserRole = UserRole.Intern,
                        ReputationalPrivilege = ReputationalPrivilege.None,
                        AccountStatus = AccountStatus.Aktivan,
                    },
                });

            builder.Entity<Resource>()
               .HasData(new List<Resource>
               {
                    new Resource
                    {
                        Id = 1,
                        Content = "Sretan Vam Bozic!",
                        DateOfPublication = new DateTime(2021,12,25,10,0,0),
                        UserId = 3,
                        Area = Area.Generalno,
                        UpVote = 6,
                        DownVote = 0,
                    },

                    new Resource
                    {
                        Id = 2,
                        Content = "Sretna Vam Nova Godina!",
                        DateOfPublication = new DateTime(2022,01,01,0,0,0),
                        UserId = 1,
                        Area = Area.Generalno,
                        UpVote = 6,
                        DownVote = 0,
                    },
               });

            builder.Entity<Comment>()
               .HasData(new List<Comment>
               {
                    new Comment
                    {
                        Id = 1,
                        Text = "Hvala, takoder!",
                        DateOfPublication = new DateTime(2021,12,25,10,2,0),
                        UserId = 1,
                        ResourceId = 1,
                        UpVote = 1,
                        DownVote = 0,
                    },

                    new Comment
                    {
                        Id = 2,
                        Text = "Hvala, takoder:)",
                        DateOfPublication = new DateTime(2021,12,25,10,5,0),
                        UserId = 2,
                        ResourceId = 1,
                        UpVote = 1,
                        DownVote = 0,
                    },

                    new Comment
                    {
                        Id = 3,
                        Text = "Hvala, takoder!<3",
                        DateOfPublication = new DateTime(2021,12,25,10,5,0),
                        UserId = 4,
                        ResourceId = 1,
                        UpVote = 1,
                        DownVote = 0,
                    },

                    new Comment
                    {
                        Id = 4,
                        Text = "Sretna novaaa!",
                        DateOfPublication = new DateTime(2022,01,01,0,1,0),
                        UserId = 6,
                        ResourceId = 2,
                        UpVote = 1,
                        DownVote = 0,
                    },

                    new Comment
                    {
                        Id = 5,
                        Text = "Sretna nova svima!",
                        DateOfPublication = new DateTime(2022,01,01,0,2,0),
                        UserId = 7,
                        ResourceId = 2,
                        UpVote = 1,
                        DownVote = 0,
                    },

                    new Comment
                    {
                        Id = 6,
                        Text = "Sretna nova!",
                        DateOfPublication = new DateTime(2022,01,01,0,30,0),
                        UserId = 5,
                        ResourceId = 2,
                        UpVote = 1,
                        DownVote = 0,
                    },

                    new Comment
                    {
                        Id = 7,
                        Text = "Sretna vam nova ljudi!",
                        DateOfPublication = new DateTime(2022,01,01,0,4,0),
                        UserId = 3,
                        ResourceId = 2,
                        UpVote = 1,
                        DownVote = 0,
                    },
               });

            builder.Entity<Answer>()
              .HasData(new List<Answer>
              {
                    new Answer
                    {
                        Id = 1,
                        Text = "Hvala!",
                        DateOfPublication = new DateTime(2021,12,25,11,0,0),
                        UserId = 3,
                        UpVote = 1,
                        DownVote = 0,
                        CommentId = 1
                    },

                    new Answer
                    {
                        Id = 2,
                        Text = "Hvala!",
                        DateOfPublication = new DateTime(2022,01,01,0,10,0),
                        UserId = 1,
                        UpVote = 1,
                        DownVote = 0,
                        CommentId = 5,
                    },
              });
        }
    }
}
