using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StackInternship.Data.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ResourceId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountStatus", "Area", "Password", "ReputationPoints", "ReputationalPrivilege", "UserName", "UserRole" },
                values: new object[,]
                {
                    { 1, 0, 0, "Harry123", 5000, 0, "Harry", 0 },
                    { 2, 0, 1, "Luna123", 5000, 0, "Luna", 0 },
                    { 3, 0, 0, "Hermione123", 100000, 0, "Hermione", 0 },
                    { 4, 0, 3, "Ron123", 1000, 0, "Ron", 0 },
                    { 5, 0, 2, "Draco123", 5000, 0, "Draco", 0 },
                    { 6, 0, 0, "Fred123", 100, 1, "Fred", 1 },
                    { 7, 0, 0, "George123", 100, 1, "George", 1 }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Area", "Content", "DateOfPublication", "DownVote", "UpVote", "UserId" },
                values: new object[] { 2, 4, "Sretna Vam Nova Godina!", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 6, 1 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Area", "Content", "DateOfPublication", "DownVote", "UpVote", "UserId" },
                values: new object[] { 1, 4, "Sretan Vam Bozic!", new DateTime(2021, 12, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, 6, 3 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AnswerId", "DateOfPublication", "DownVote", "ResourceId", "Text", "UpVote", "UserId" },
                values: new object[,]
                {
                    { 4, null, new DateTime(2022, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), 0, 2, "Sretna novaaa!", 1, 6 },
                    { 5, null, new DateTime(2022, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), 0, 2, "Sretna nova svima!", 1, 7 },
                    { 6, null, new DateTime(2022, 1, 1, 0, 30, 0, 0, DateTimeKind.Unspecified), 0, 2, "Sretna nova!", 1, 5 },
                    { 7, null, new DateTime(2022, 1, 1, 0, 4, 0, 0, DateTimeKind.Unspecified), 0, 2, "Sretna vam nova ljudi!", 1, 3 },
                    { 1, null, new DateTime(2021, 12, 25, 10, 2, 0, 0, DateTimeKind.Unspecified), 0, 1, "Hvala, takoder!", 1, 1 },
                    { 2, null, new DateTime(2021, 12, 25, 10, 5, 0, 0, DateTimeKind.Unspecified), 0, 1, "Hvala, takoder:)", 1, 2 },
                    { 3, null, new DateTime(2021, 12, 25, 10, 5, 0, 0, DateTimeKind.Unspecified), 0, 1, "Hvala, takoder!<3", 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CommentId", "DateOfPublication", "DownVote", "Text", "UpVote", "UserId" },
                values: new object[] { 2, 5, new DateTime(2022, 1, 1, 0, 10, 0, 0, DateTimeKind.Unspecified), 0, "Hvala!", 1, 1 });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CommentId", "DateOfPublication", "DownVote", "Text", "UpVote", "UserId" },
                values: new object[] { 1, 1, new DateTime(2021, 12, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), 0, "Hvala!", 1, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "ResourceId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
