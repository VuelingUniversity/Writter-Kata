using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;

namespace Writter_Kata.Test
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void Test_Factory_Create_Writter()
        {
            Dictionary<string, IFormatable> formater = new Dictionary<string, IFormatable> { { "json", new JsonFormater() } };
            IWritteable writter = new Factory(formater).GetWritter("json");
            Assert.IsInstanceOfType(writter, typeof(Writter));
        }

        [TestMethod]
        public void Test_FactoryCloud_Create_WritterCloud()
        {
            Dictionary<string, IFormatable> formater = new Dictionary<string, IFormatable> { { "json", new JsonFormater() } };
            IWritteable writterCloud = new FactoryCloud(formater).GetWritter("json");
            Assert.IsInstanceOfType(writterCloud, typeof(WritterCloud));
        }
    }
}
