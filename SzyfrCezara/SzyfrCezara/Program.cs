using System;
using System.Text;

namespace SzyfrCezara
{
    public class Program
    {
        public static string Szyfruj(string tekstJawny, int klucz)
        {
            StringBuilder wynik = new StringBuilder();

            foreach (char znak in tekstJawny)
            {
                if (znak == ' ')
                {
                    wynik.Append(' ');
                }
                else if (znak >= 'a' && znak <= 'z')
                {
                    int kodBazowy = znak - 'a';
                    int przesunietyKod = (kodBazowy + klucz) % 26;
                    if (przesunietyKod < 0)
                    {
                        przesunietyKod += 26;
                    }

                    char nowyZnak = (char)('a' + przesunietyKod);
                    wynik.Append(nowyZnak);
                }
                else
                {
                    wynik.Append(znak);
                }
            }

            return wynik.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM: SZYFR CEZARA ===");
            Console.Write("Wprowadź tekst jawny: ");
            string tekst = Console.ReadLine() ?? string.Empty;

            Console.Write("Wprowadź klucz: ");
            if (int.TryParse(Console.ReadLine(), out int klucz))
            {
                string tekstZaszyfrowany = Szyfruj(tekst, klucz);
                Console.WriteLine($"Tekst zaszyfrowany: {tekstZaszyfrowany}");
            }
        }
    }
}