using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkaTeleadresowa
{
    class MenuGlowne
    {
        public void MenuGlowneProgramu()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(49, 3);
            Console.WriteLine("  Menu główne programu  ");

            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(42, 6);
            Console.WriteLine(" T ");

            Console.SetCursorPosition(48, 6);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" - Książka Telekomunikacyjna");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(42, 8);
            Console.WriteLine(" E ");

            Console.SetCursorPosition(48, 8);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" - Wyjście z programu");

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.T:
                    MenuTelekomunikacyjne menuTelekomukacyjne = new MenuTelekomunikacyjne();
                    menuTelekomukacyjne.MenuTele();
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
