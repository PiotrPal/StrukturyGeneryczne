using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KolekcjeGeneryczneTest {
    [TestClass]
    public class DictionaryTest {
        [TestMethod]
        public void SlownikJakoMapa() {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            Assert.AreEqual("jeden", mapa[1]);
        }

        [TestMethod]
        public void SlownikWyszukiwanie() {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            Assert.IsTrue(mapa.ContainsKey(1));
            Assert.IsTrue(mapa.ContainsValue("dwa"));
        }

        [TestMethod]
        public void SlownikUsuwaniePoValue() {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            mapa.Remove(1);

            Assert.AreEqual(2, mapa.Count);
        }

        [TestMethod]
        public void SlownikClear() {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            mapa.Clear();

            Assert.AreEqual(0, mapa.Count);
        }

        [TestMethod]
        public void SlownikJakoSlownik() {
            var mapa = new Dictionary<string, string>();
            mapa.Add("one", "jeden");
            mapa.Add("two", "dwa");
            mapa.Add("three", "trzy");

            Assert.AreEqual("jeden", mapa["one"]);
        }
    }
}
