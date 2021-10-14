using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace KsiazkaTeleadresowa
{
    class UsunAbonenta
    {
        public List<string>  listaAbonentowDoUsuniecia = new List<string>{};
        public int linia=14;
        public int wyborUsera;
        public string path = "ksiazka.txt";

        public void DeleteAbonent()
        {
            Console.Clear();
            Console.SetCursorPosition(35, 2);
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("  Usuń Abonenta z książki telekomunikacyjnej  ");

            Console.ResetColor();

            Console.SetCursorPosition(2, 7);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Z poniższej listy Abonentów wybierz index który chcesz usunąć i wpisz w pole pod listą.");

            Console.SetCursorPosition(2, 10);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(2, 11);
            Console.WriteLine("  index  |     Abonent");

            Console.SetCursorPosition(2, 12);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

            

            int i = 0;

            if (!File.Exists(path))
            {
                Console.SetCursorPosition(35, 15);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Plik nie istnieje lub baza jest pusta!");

                Console.SetCursorPosition(35, 16);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Dodaj abonenta do książki, aby funkcja usuwania zaczeła działać.");

                Console.SetCursorPosition(35, 17);
                Console.WriteLine("Pamiętaj jednak że, aby usunąć Abonenta w bazie muszą być co najmniej dwa rekordy.");

                Console.SetCursorPosition(35, 19);
                Console.WriteLine("Za 3 sekundy zostaniesz przeniesiony do menu telekomunikacyjnego");

                Thread.Sleep(3000);
                MenuTelekomunikacyjne menuTelekomunikacyjne = new MenuTelekomunikacyjne();
                menuTelekomunikacyjne.MenuTele();
            }
            else
            {
                var wczytajPlik = File.ReadAllLines(path);

                foreach (var item in wczytajPlik)
                {
                    listaAbonentowDoUsuniecia.Add(item);
                }
            }

            foreach (var item_1 in listaAbonentowDoUsuniecia)
            {
                Console.SetCursorPosition(4, linia);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(i+".");

                Console.SetCursorPosition(8, linia);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(item_1);

                Console.SetCursorPosition(2, linia + 1);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("----------------------------------------------------------------------------------------------------------");

                linia += 3;
                i++;
            }

            Console.SetCursorPosition(4, linia + 4);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Podaj numer indexu do usunięcia: ");

            wyborUsera = int.Parse(Console.ReadLine());

            UsunAbonentaZListy();
        }

        public void UsunAbonentaZListy()
        {
            Console.Clear();

            Console.SetCursorPosition(4, 2);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Czy potwierdzasz usunięcie Abonenta z bazy?");

            Console.SetCursorPosition(2, 4);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(listaAbonentowDoUsuniecia[wyborUsera]);

            Console.SetCursorPosition(4, 6);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("t/n: ");

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.T:
                case ConsoleKey.Y:
                    listaAbonentowDoUsuniecia.RemoveAt(wyborUsera);
                    File.Delete(path);
                    Thread.Sleep(500);
                    File.AppendAllLines(path, listaAbonentowDoUsuniecia);
                    Console.SetCursorPosition(4, 10);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Rekord został usunięty nieodwracalnie!");

                    Console.SetCursorPosition(2, 11);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Za 3 sekundy zostaniesz przeniesiony do menu telekomunikacyjnego.");
                    Thread.Sleep(3000);

                    MenuTelekomunikacyjne menuTelekomunikacyjne1 = new MenuTelekomunikacyjne();
                    menuTelekomunikacyjne1.MenuTele();
                    break;
                case ConsoleKey.N:
                    Console.SetCursorPosition(2, 11);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Za 3 sekundy zostaniesz przeniesiony do menu telekomunikacyjnego.");
                    Thread.Sleep(3000);
                    MenuTelekomunikacyjne menuTelekomunikacyjne = new MenuTelekomunikacyjne();
                    menuTelekomunikacyjne.MenuTele();
                    break;
            }
        }
    }
}
