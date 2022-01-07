using System;

namespace StackInternship.Presentation.Methods
{
    class PrintMethods
    {
        public static void PrintLoginInput()
        {
            Console.Clear();

            Console.WriteLine("Dobrodošli u StackInternship!");
            Console.WriteLine("Molim vas odaberite željenu akciju:");
            Console.WriteLine("1 - Register");
            Console.WriteLine("2 - Login");
            Console.WriteLine("3 - Izlaz iz aplikacije");
            Console.Write("\r\nUnesite odabir: ");
        }

        public static void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine("Odaberite akciju:");
            Console.WriteLine();
            Console.WriteLine("1 - Objavljeni resursi");
            Console.WriteLine("2 - Korisnici");
            Console.WriteLine("3 - Neodgovoreno");
            Console.WriteLine("4 - Popularno");
            Console.WriteLine("5 - Moj profil");
            Console.Write("\r\nUnesite odabir: ");
        }

        public static void AreaMenu()
        {
            Console.Clear();

            Console.WriteLine("Odaberite područje:");
            Console.WriteLine();
            Console.WriteLine("1 - Dev");
            Console.WriteLine("2 - Dizajn");
            Console.WriteLine("3 - Marketing");
            Console.WriteLine("4 - Multimedija");
            Console.WriteLine("5 - Generalno");
            Console.Write("\r\nUnesite odabir: ");
        }

        public static void UserSelectionMenu()
        {
            Console.Clear();

            Console.WriteLine("Odaberite kako želite filtrirati korisnike:");
            Console.WriteLine();
            Console.WriteLine("1 - Po području");
            Console.WriteLine("2 - Po roli korisnika");
            Console.Write("\r\nUnesite odabir: ");
        }

        public static void EditUserMenu()
        {
            Console.Clear();

            Console.WriteLine("Odaberite željenu radnju:");
            Console.WriteLine();
            Console.WriteLine("1 - Promjena korisničkog imena");
            Console.WriteLine("2 - Promjena lozinke");
            Console.WriteLine("3 - Povratak na dashboard");
            Console.Write("\r\nUnesite odabir: ");
        }

        public static void EditCommentMenu()
        {

            Console.WriteLine("Odaberite željenu radnju:");
            Console.WriteLine();
            Console.WriteLine("1 - UpVote komentar");
            Console.WriteLine("2 - DownVote komentar");
            Console.WriteLine("3 - Uređivanje komentara");
            Console.WriteLine("4 - Brisanje komentara");
            Console.WriteLine("5 - Kreiranje novog komentara");
            Console.WriteLine("6 - Kreiranje nove objave");
            Console.WriteLine("7 - Povratak na izbornik");
            Console.Write("\r\nUnesite odabir: ");
        }
    }
}
