using _3_KlasyInterfejsyGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _3_KlasyInterfejsyGeneryczneTest {
    [TestClass]
    public class KolejkaKolowa2Test {

        [TestMethod]
        public void NowaKolejkaPusta() {
            var kolejka = new KolejkaKolowa2<double>();

            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void Kolejka3JestPelna() {
            var kolejka = new KolejkaKolowa2<double>(3);

            kolejka.Zapisz(1);
            kolejka.Zapisz(2);
            kolejka.Zapisz(3);

            Assert.IsTrue(kolejka.JestPelny);
        }

        [TestMethod]
        public void FirstInFirstOut() {
            var kolejka = new KolejkaKolowa2<double>(3);
            var wartosc1 = 3;
            var wartosc2 = 4;

            kolejka.Zapisz(wartosc1);
            kolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc1, kolejka.Odczytaj());
            Assert.AreEqual(wartosc2, kolejka.Odczytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void FirstInFirstOutStr() {
            var kolejka = new KolejkaKolowa2<string>(3);
            var wartosc1 = "duzy";
            var wartosc2 = "maly";

            kolejka.Zapisz(wartosc1);
            kolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc1, kolejka.Odczytaj());
            Assert.AreEqual(wartosc2, kolejka.Odczytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void Nadpisywanie() {
            var kolejka = new KolejkaKolowa2<double>(3);
            var wartosci = new[] { 1.2, 3, 3.4, 2.1, 86, 32 };

            foreach (var value in wartosci) {
                kolejka.Zapisz(value);
            }

            Assert.IsTrue(kolejka.JestPelny);
            Assert.AreEqual(wartosci[3], kolejka.Odczytaj());
            Assert.AreEqual(wartosci[4], kolejka.Odczytaj());
            Assert.AreEqual(wartosci[5], kolejka.Odczytaj());
            Assert.IsTrue(kolejka.JestPusty);

        }
    }
}
