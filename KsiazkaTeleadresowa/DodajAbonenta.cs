using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;


namespace KsiazkaTeleadresowa
{
    class DodajAbonenta
    {
        public List<string> listaAbonentow = new List<string> { };
        public string path = "ksiazka.txt";
        public void ZapiszAbonenta()
        {
            Console.Clear();
            //formularz pól
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(45, 2);
            Console.WriteLine("   Wypełnij poniższy formularz  ");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition(2, 6);
            Console.WriteLine("imie:");

            Console.SetCursorPosition(55, 6);
            Console.WriteLine("nazwisko:");

            Console.SetCursorPosition(2, 8);
            Console.WriteLine("telefon:");

            Console.SetCursorPosition(55, 8);
            Console.WriteLine("email:");

            Console.SetCursorPosition(2, 10);
            Console.WriteLine("miasto:");

            Console.SetCursorPosition(55, 10);
            Console.WriteLine("kod:");

            Console.SetCursorPosition(2, 12);
            Console.WriteLine("ulica:");

            Console.SetCursorPosition(55, 12);
            Console.WriteLine("nr mieszkania:");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(8, 6);
            var imieAbonenta = Console.ReadLine();

            Console.SetCursorPosition(65, 6);
            var nazwiskoAbonenta = Console.ReadLine();

            Console.SetCursorPosition(11, 8);
            var telefonAbonenta = Console.ReadLine();

            Console.SetCursorPosition(62, 8);
            var emailAbonenta = Console.ReadLine();

            Console.SetCursorPosition(10, 10);
            var miastoAbonenta = Console.ReadLine();

            Console.SetCursorPosition(60, 10);
            var kodAbonenta = Console.ReadLine();

            Console.SetCursorPosition(9, 12);
            var ulicaAbonenta = Console.ReadLine();

            Console.SetCursorPosition(70, 12);
            var mieszkanieAbonenta = Console.ReadLine();

            //potwierdzenie czy dane są ok!
            var rekordAbonenta = imieAbonenta + " " + nazwiskoAbonenta + " " + telefonAbonenta + " " + emailAbonenta + "  |  " + miastoAbonenta + " " + kodAbonenta + " ul." + ulicaAbonenta + " m." + mieszkanieAbonenta;

            Console.Clear();
            Console.SetCursorPosition(4, 2);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Czy dane poniżej są poprawne? (t/n) ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(2, 4);
            Console.WriteLine(rekordAbonenta);

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.T:
                case ConsoleKey.Y:
                    if (!File.Exists(path))
                    {
                        listaAbonentow.Add(rekordAbonenta);
                        File.AppendAllLines(path, listaAbonentow);
                        Console.SetCursorPosition(4, 6);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Plik został utworzony i rekord zapisany!");
                        Console.SetCursorPosition(2, 8);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Za 3 sekundy zostaniesz przeniesiony do menu telekomukacyjnego");
                        Thread.Sleep(3000);
                        MenuTelekomunikacyjne menuTelekomunikacyjne = new MenuTelekomunikacyjne();
                        menuTelekomunikacyjne.MenuTele();
                    }
                    else
                    {
                        var odczytPliku = File.ReadAllLines(path);
                        foreach (var item in odczytPliku)
                        {
                            listaAbonentow.Add(item);
                        }
                        Thread.Sleep(500);
                        listaAbonentow.Add(rekordAbonenta);
                        Thread.Sleep(500);
                        File.Delete(path);
                        Thread.Sleep(500);
                        File.AppendAllLines(path, listaAbonentow);
                        Thread.Sleep(500);
                        Console.SetCursorPosition(2, 8);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Za 3 sekundy zostaniesz przeniesiony do menu telekomukacyjnego");
                        Thread.Sleep(3000);
                        MenuTelekomunikacyjne menuTelekomunikacyjne = new MenuTelekomunikacyjne();
                        menuTelekomunikacyjne.MenuTele();
                    }
                    break;
                case ConsoleKey.N:
                    MenuTelekomunikacyjne menu = new MenuTelekomunikacyjne();
                    menu.MenuTele();
                    break;
                default:
                    Environment.Exit(1);

                    break;

            }
        }
    }
}
