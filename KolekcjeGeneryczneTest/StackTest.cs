using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KolekcjeGeneryczneTest {
    [TestClass]
    public class StackTest {//podobnie jak kolejka
        
        [TestMethod]
        public void UzycPeek() {
            var stos = new Stack<int>();
            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);

            Assert.AreEqual(4, stos.Peek());
        }

        [TestMethod]
        public void UzycContains() {
            var stos = new Stack<int>();
            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);

            Assert.IsTrue(stos.Contains(3));
        }
    }
}
