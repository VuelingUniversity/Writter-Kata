using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;

namespace Writter_Kata.Test
{
    [TestClass]
    public class ContainerTest
    {
        [TestMethod]
        public void Test_Create_Container_Contains_IFactoryable()
        {
            Container container = new Container(1);
            Assert.IsTrue(container.Factory.GetType().GetInterfaces().Contains(typeof(IFactoryable)));
        }

        [TestMethod]
        public void Test_Create_Container_With_FactoryLocal()
        {
            Container container = new Container(1);
            Assert.IsInstanceOfType(container.Factory, typeof(Factory));
        }

        [TestMethod]
        public void Test_Create_Container_With_FactoryCloud()
        {
            Container container = new Container(2);
            Assert.IsInstanceOfType(container.Factory, typeof(FactoryCloud));
        }

        [TestMethod]
        public void Test_Create_Container_Fail()
        {        
            Assert.ThrowsException<Exception>(() => new Container(4));
        }

    }
}
