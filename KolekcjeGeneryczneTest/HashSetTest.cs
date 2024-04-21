using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KolekcjeGeneryczneTest {
    [TestClass]
    public class HashSetTest {
        [TestMethod]
        public void IntersectTest() {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.IntersectWith(set2);//wspolne elementy

            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));
        }

        [TestMethod]
        public void UnionTest() {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.UnionWith(set2);// wszystkie wartosci

            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void SymmetricExceptTest() {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.SymmetricExceptWith(set2);// unikalne wartosci w obu

            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));

        }
        [TestMethod]
        public void RemoveTest() {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.Remove(1);

            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));
        }

        [TestMethod]
        public void RemoveWhereTest() {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.RemoveWhere(x => x > 1);

            Assert.IsTrue(set1.SetEquals(new[] { 1 }));
        }

        [TestMethod]
        public void RemoveContains() {
            var set1 = new HashSet<int>() { 1, 2, 3 };

            Assert.IsTrue(set1.Contains(3));
        }
    }
}
