using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkaTeleadresowa
{
    class WyszukajAbonenta
    {
        public string szukaj;
        public List<string> listaDoWyszukiwania = new List<string> { };
        public string path = "ksiazka.txt";
        public int j = 6;

        public void SearchAbonent()
        {
            Console.Clear();

            Console.SetCursorPosition(35, 2);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  Wyszukaj Abonenta w książce telekomunikacyjnej  ");

            Console.ResetColor();
            Console.SetCursorPosition(4, 4);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Podaj ciąg znaków do wyszukania? ");
            szukaj = Console.ReadLine();

            var daneDoWyszukania = File.ReadAllLines(path);
            foreach (var item in daneDoWyszukania)
            {
                listaDoWyszukiwania.Add(item);
            }

            foreach (string value in listaDoWyszukiwania.FindAll(element => element.StartsWith(szukaj)))
            {
                Console.SetCursorPosition(2, j);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Wynik wyszukiwania: ");

                Console.SetCursorPosition(23, j);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(value);
                j += 2;
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(4, j + 4);
            Console.WriteLine("<klawisz na klawiaturze>  -  Powrót do menu telekomunikacyjnego");
            Console.ReadKey();
            MenuTelekomunikacyjne menuTelekomunikacyjne = new MenuTelekomunikacyjne();
            menuTelekomunikacyjne.MenuTele();
        }
    }
}
