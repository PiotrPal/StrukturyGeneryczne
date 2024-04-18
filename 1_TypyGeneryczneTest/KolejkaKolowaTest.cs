using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_TypyGeneryczne;
using System;

namespace _1_TypyGeneryczneTest {
    [TestClass]
    public class KolejkaKolowaTest {
        [TestMethod]
        public void NowaKolejkaPusta() {
            var kolejka = new KolejkaKolowa();

            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void Kolejka3JestPelna() {
            var kolejka = new KolejkaKolowa(3);

            kolejka.Zapisz(1);
            kolejka.Zapisz(2);
            kolejka.Zapisz(3);

            Assert.IsTrue(kolejka.JesyPelny);
        }

        [TestMethod]
        public void FirstInFirstOut() {
            var kolejka = new KolejkaKolowa(3);
            var wartosc1 = 3;
            var wartosc2 = 4;

            kolejka.Zapisz(wartosc1);
            kolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc1, kolejka.Odczytaj());
            Assert.AreEqual(wartosc2, kolejka.Odczytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void Nadpisywanie() {
            var kolejka = new KolejkaKolowa(3);
            var wartosci = new[] { 1.2, 3, 3.4, 2.1, 86, 32 };

            foreach(var value in wartosci) {
                kolejka.Zapisz(value);
            }

            Assert.IsTrue(kolejka.JesyPelny);
            Assert.AreEqual(wartosci[3], kolejka.Odczytaj());
            Assert.AreEqual(wartosci[4], kolejka.Odczytaj());
            Assert.AreEqual(wartosci[5], kolejka.Odczytaj());
            Assert.IsTrue(kolejka.JestPusty);

        }
    }
}