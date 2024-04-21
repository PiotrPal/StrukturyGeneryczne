using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KolekcjeGeneryczneTest {
    [TestClass]
    public class LinkedListTest {
        [TestMethod]
        public void LListDodawaniePoElemencie() {
            var list = new LinkedList <string> ();

            list.AddFirst("Talar");
            list.AddLast("Bard");
            list.AddAfter(list.First, "Zoltan");

            Assert.AreEqual("Zoltan",list.First.Next.Value);
        }

        [TestMethod]
        public void LListDodawaniePrzedElementem() {
            var list = new LinkedList<string>();

            list.AddFirst("Talar");
            list.AddLast("Bard");
            list.AddBefore(list.First, "Zoltan");

            Assert.AreEqual("Zoltan", list.First.Value);
        }

        [TestMethod]
        public void LListUsuwanieElementuOstatniego() {
            var list = new LinkedList<string>();

            list.AddFirst("Talar");
            list.AddLast("Bard");
            list.RemoveLast();

            Assert.AreEqual(list.Last.Value, list.First.Value);
        }

        [TestMethod]
        public void LListUsuwanieElementuWybranego() {
            var list = new LinkedList<string>();

            list.AddFirst("Talar");
            list.AddLast("Bard");
            list.Remove("Talar");

            Assert.AreEqual("Bard", list.First.Value);
        }

        [TestMethod]
        public void LListCzyZawieraElement() {
            var list = new LinkedList<string>();

            list.AddFirst("Talar");
            list.AddLast("Geralt");
            list.AddLast("Bard");

            Assert.IsTrue(list.Contains("Geralt"));
        }

        [TestMethod]
        public void LListClear() {
            var list = new LinkedList<string>();

            list.AddFirst("Talar");
            list.AddLast("Geralt");
            list.AddLast("Bard");

            list.Clear();

            Assert.AreEqual(0,list.Count);
        }
    }
}
