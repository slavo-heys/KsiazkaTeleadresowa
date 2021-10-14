using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkaTeleadresowa
{
    class MenuTelekomunikacyjne
    {
        public void MenuTele()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(40, 2);
            Console.WriteLine("  Menu telekomunikacyjne  ");

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(2, 6);
            Console.WriteLine(" L ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(5, 6);
            Console.WriteLine(" - wyświetl listę wszystkich abonentów");

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(60, 6);
            Console.WriteLine(" S ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(63, 6);
            Console.WriteLine(" - wyszukaj abonenta");

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(2, 8);
            Console.WriteLine(" A ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(5, 8);
            Console.WriteLine(" - dodaj abonenta do książki");

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(60, 8);
            Console.WriteLine(" D ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(63, 8);
            Console.WriteLine(" - usuń abonenta z książki");

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(2, 10);
            Console.WriteLine(" M ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(5, 10);
            Console.WriteLine(" - wróć do menu głównego");

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(60, 10);
            Console.WriteLine(" E ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(63, 10);
            Console.WriteLine(" - wyjdź z programu");

            Console.SetCursorPosition(55, 14);
            Console.WriteLine("? ");

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.L:
                    ListaAbonentow listaAbonentow = new ListaAbonentow();
                    listaAbonentow.ListaAbonent();
                    break;
                case ConsoleKey.S:
                    WyszukajAbonenta wyszukajAbonenta = new WyszukajAbonenta();
                    wyszukajAbonenta.SearchAbonent();
                    break;
                case ConsoleKey.A:
                    DodajAbonenta dodajAbonenta = new DodajAbonenta();
                    dodajAbonenta.ZapiszAbonenta();
                    break;
                case ConsoleKey.D:
                    UsunAbonenta usunAbonenta= new UsunAbonenta();
                    usunAbonenta.DeleteAbonent();
                    break;
                case ConsoleKey.M:
                    MenuGlowne mG = new MenuGlowne();
                    mG.MenuGlowneProgramu();
                    break;
                case ConsoleKey.E:
                    Environment.Exit(1);
                    break;
                default:
                    Environment.Exit(1);
                    break;

            }
        }
    }
}
