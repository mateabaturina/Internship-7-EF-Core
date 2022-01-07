using StackInternship.Domain.Factories;
using System;
using System.Linq;

namespace StackInternship.Presentation.Methods
{
    class ValidateMethods
    {
        static bool CheckingName(string name)
        {
            return name == "";
        }

        public static string CheckingNameInput(string name)
        {
            while (CheckingName(name))
            {
                Console.WriteLine("Korisničko ime ne može biti prazno! Molim vas ponovo unesite.");
                Console.Write("\r\nUnesite Korisničko ime: ");
                name = Console.ReadLine();
            }

            return name;
        }

        private static string CheckingIfNameExists(string name)
        {
            while (true)
            {
                var context = DbContextFactory.GetStackInternshipDbContext();
                if (context.Users.Any(c => c.UserName == name))
                {
                    Console.WriteLine("Korisnik s tim korisničkim imenom već postoji! Molim vas ponovo unesite.");
                    Console.Write("\r\nUnesite korisničko ime: ");
                    name = Console.ReadLine();
                }

                else
                    break;
            }

            return name;
        }

        private static string CheckingIfUserNameIsValid(string name)
        {
            while (true)
            {
                var context = DbContextFactory.GetStackInternshipDbContext();
                if (context.Users.Any(c => c.UserName == name))
                    break;

                else
                {
                    Console.WriteLine("Korisnik s tim korisničkim imenom ne postoji! Molim vas ponovo unesite.");
                    Console.Write("\r\nUnesite korisničko ime: ");
                    name = Console.ReadLine();
                }       
            }
            return name;
        }

        public static string NameInputRegistration()
        {
            Console.Write("\r\nUnesite korisničko ime: ");
            var name = Console.ReadLine();

            name = CheckingNameInput(name);
            name = CheckingIfNameExists(name);

            return name;
        }

        public static string NameInput()
        {
            Console.Write("\r\nUnesite korisničko ime: ");
            var name = Console.ReadLine();

            name = CheckingNameInput(name);
            name = CheckingIfUserNameIsValid(name);

            return name;
        }

        static bool CheckingPassword(string password)
        {
            return password == "";
        }

        public static string CheckingPasswordInput(string password)
        {
            while (CheckingPassword(password))
            {
                Console.WriteLine("Lozinka ne može biti prazna! Molim vas ponovo unesite.");
                Console.Write("\r\nUnesite Lozinku: ");
                password = Console.ReadLine();
            }

            return password;
        }

        public static string PasswordInput()
        {
            Console.Write("\r\nUnesite lozinku: ");
            var password = Console.ReadLine();

            password = CheckingPasswordInput(password);

            return password;
        }

        static bool CheckingText(string text)
        {
            return text == "";
        }

        public static string CheckingTextInput(string text)
        {
            while (CheckingText(text))
            {
                Console.WriteLine("Tekst ne može biti prazan! Molim vas ponovo unesite.");
                Console.Write("\r\nUnesite tekst: ");
                text = Console.ReadLine();
            }

            return text;
        }

        public static string TextInput()
        {
            Console.Write("\r\nUnesite tekst: ");
            var text = Console.ReadLine();

            text = CheckingTextInput(text);

            return text;
        }
    }
}
