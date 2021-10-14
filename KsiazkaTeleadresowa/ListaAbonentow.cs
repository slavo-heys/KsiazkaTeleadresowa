using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkaTeleadresowa
{
    class ListaAbonentow
    {
        public int j = 6;
        public List<string> listaBezSort = new List<string> { };
        public void ListaAbonent()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(35, 2);
            Console.WriteLine("  Lista wszystkich Abonentów w książce teleadresowej  ");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int i = 1;
            
            var path = "ksiazka.txt";
            if (!File.Exists(path))
            {
                Console.SetCursorPosition(10, 6);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Twoja książka jest pusta lub jeszcze nie istnieje!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(10, 8);
                Console.WriteLine("Dodaj jednego abonenta aby utworzyć książkę.");
                Console.SetCursorPosition(10, 10);
                Console.WriteLine("Nacisnij <D> program przeniesie cię do menu dodawania abonentów.");
                Console.SetCursorPosition(10, 12);
                Console.WriteLine("Naciśnięcie innego klawisza przeniesie Cię do menu telekomunikacyjnego.");
                Console.SetCursorPosition(10, 14);
                Console.WriteLine("? "); ;

                ConsoleKeyInfo key_1;
                key_1 = Console.ReadKey();

                switch (key_1.Key)
                {
                    case ConsoleKey.D:
                        DodajAbonenta dodajAbonenta = new DodajAbonenta();
                        dodajAbonenta.ZapiszAbonenta();
                        break;
                    default:
                        MenuTelekomunikacyjne menuT = new MenuTelekomunikacyjne();
                        menuT.MenuTele();
                        break;
                }

            }
            else
            {
                var wczytajText = File.ReadAllLines(path);
                foreach (var item in wczytajText)
                {
                    listaBezSort.Add(item);
                }

                listaBezSort.Sort();

                foreach (var wczytaneLinie in listaBezSort)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(2, j);
                    Console.WriteLine(i+".");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(6, j);
                    Console.WriteLine(wczytaneLinie);
                    i++;
                    j += 2;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(4, j + 2);
            Console.WriteLine("Koniec listy Abonentów.");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("T - menu telekomunikacyjne         M - menu główne");

            ConsoleKeyInfo key_2;
            key_2 = Console.ReadKey();
            switch (key_2.Key)
            {
                case ConsoleKey.T:
                    MenuTelekomunikacyjne menuTele = new MenuTelekomunikacyjne();
                    menuTele.MenuTele();
                    break;
                case ConsoleKey.M:
                    MenuGlowne menuGlowne = new MenuGlowne();
                    menuGlowne.MenuGlowneProgramu();
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
        }
    }
}
