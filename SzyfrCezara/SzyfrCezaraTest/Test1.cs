using Microsoft.VisualStudio.TestTools.UnitTesting;
using SzyfrCezara;

namespace SzyfrCezaraTesty
{
    [TestClass]
    public class SzyfrCezaraTest
    {
        [TestMethod]
        public void Test1_DanePodstawowe()
        {
            // Nr testu 1: Dane podstawowe (klucz dodatni, mniejszy od długości alfabetu)
            string tekstJawny = "abc";
            int klucz = 3;
            string oczekiwanyWynik = "def";

            string wynik = Program.Szyfruj(tekstJawny, klucz);

            Assert.AreEqual(oczekiwanyWynik, wynik);
        }

        [TestMethod]
        public void Test2_Zawijanie()
        {
            // Nr testu 2: „Zawijanie” (gdy litery w tekście i klucz wychodzą poza alfabet)
            string tekstJawny = "xyz";
            int klucz = 3;
            string oczekiwanyWynik = "abc";

            string wynik = Program.Szyfruj(tekstJawny, klucz);

            Assert.AreEqual(oczekiwanyWynik, wynik);
        }

        [TestMethod]
        public void Test3_Odszyfrowanie()
        {
            // Nr testu 3: Odszyfrowanie (klucz ujemny)
            string tekstJawny = "def";
            int klucz = -3;
            string oczekiwanyWynik = "abc";

            string wynik = Program.Szyfruj(tekstJawny, klucz);

            Assert.AreEqual(oczekiwanyWynik, wynik);
        }

        [TestMethod]
        public void Test4_KluczWiekszyNizAlfabet()
        {
            // Nr testu 4: Klucz większy niż długość alfabetu
            string tekstJawny = "abc";
            int klucz = 29; // 29 % 26 = 3
            string oczekiwanyWynik = "def";

            string wynik = Program.Szyfruj(tekstJawny, klucz);

            Assert.AreEqual(oczekiwanyWynik, wynik);
        }

        [TestMethod]
        public void Test5_SpacjaWTekscie()
        {
            // Nr testu 5: Spacja w tekście
            string tekstJawny = "ab cd";
            int klucz = 2;
            string oczekiwanyWynik = "cd ef";

            string wynik = Program.Szyfruj(tekstJawny, klucz);

            Assert.AreEqual(oczekiwanyWynik, wynik);
        }
    }
}