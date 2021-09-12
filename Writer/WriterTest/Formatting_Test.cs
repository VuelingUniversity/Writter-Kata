using Microsoft.VisualStudio.TestTools.UnitTesting;
using Writer.services;
using Microsoft.Extensions.DependencyInjection;
using Writer.interfaces;
using Writer.models;
using System.Collections.Generic;

namespace WriterTest
{
    [TestClass]
    public class Formatting_Test
    {
        [TestMethod]
        public void Xml_Formatting_Test()
        {
            WriterModel w = Container.Build().GetService<IFactory>().CreateWriter("xml");
            Assert.AreEqual("xml", w.formatName);
        }

        [TestMethod]
        public void Txt_Formatting_Test()
        {
            WriterModel w = Container.Build().GetService<IFactory>().CreateWriter("txt");
            Assert.AreEqual("txt", w.formatName);
        }

        [TestMethod]
        public void Json_Formatting_Test()
        {
            WriterModel w = Container.Build().GetService<IFactory>().CreateWriter("json");
            Assert.AreEqual("json", w.formatName);
        }

        [TestMethod]
        public void Non_Existing_Extension_Formatting_Test()
        {
            Assert.ThrowsException<KeyNotFoundException>(() => Container.Build().GetService<IFactory>().CreateWriter("aaa"));
        }
    }
}
