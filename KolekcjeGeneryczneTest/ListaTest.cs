using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KolekcjeGeneryczneTest {
    [TestClass]
    public class ListaTest {
        [TestMethod]
        public void ListaDodawanieLast() {
            List<int> liczby = new List<int> { 1, 2, 3, };

            int newValue = 4;
            liczby.Add(newValue);

            Assert.AreEqual(newValue, liczby[3]);
        }

        [TestMethod]
        public void ListaDodawanieNaPozycji() {
            List<int> liczby = new List<int> { 1, 2, 3, };

            int newValue = 4;
            int index = 1;
            liczby.Insert(index, newValue);

            Assert.AreEqual(newValue, liczby[index]);
        }

        [TestMethod]
        public void ListaUsuwanieElement() {
            List<int> liczby = new List<int> { 1, 2, 3, };

            var deleteValue = 2;
            liczby.Remove(deleteValue);

            Assert.IsTrue(liczby.Count == 2);
            Assert.IsTrue(!liczby.Contains(deleteValue));
            Assert.IsTrue(liczby.SequenceEqual(new[] { 1, 3 }));
        }

        [TestMethod]
        public void ListaUsuwanieNaPozycji() {
            List<int> liczby = new List<int> { 1, 2, 3, };

            var deleteIndex = 2;
            liczby.RemoveAt(deleteIndex);

            Assert.IsTrue(liczby.SequenceEqual(new[] { 1, 2 }));
        }

        [TestMethod]
        public void ListaFindIndexOf() {
            List<int> liczby = new List<int> { 55, 44, 3, };

            Assert.AreEqual(liczby.IndexOf(3), 2); 
        }

        [TestMethod]
        public void ListaFind() {
            List<int> liczby = new List<int> { 55, 44, 3, };

            Assert.IsTrue(liczby.Contains(3));
        }

        [TestMethod]
        public void ListaDodawanieZakres() {
            List<int> liczby = new List<int> { 55, 44, 3, };
            var zakres = new[] { 55,22,11};

            liczby.AddRange(zakres);

            Assert.AreEqual(6,liczby.Count);
            Assert.AreEqual(11, liczby[5]);
        }
    }
}
