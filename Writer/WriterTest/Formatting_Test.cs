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
        public void Existing_Format_Formating_Local_Factory_Test()
        {
            Dictionary<string, Format> formatList = new Dictionary<string, Format>();
            formatList.Add("json", new JsonFormatter());

            IFactory factory = new LocalWriterFactory(formatList);
            WriterModel w = factory.CreateWriter("json");
            Assert.AreEqual("json", w.formatName);
        }

        [TestMethod]
        public void Non_Existing_Extension_Local_Factory_Formating_Test()
        {
            Dictionary<string, Format> formatList = new Dictionary<string, Format>();
            formatList.Add("json", new JsonFormatter());
            IFactory factory = new LocalWriterFactory(formatList);
            Assert.ThrowsException<KeyNotFoundException>(() => factory.CreateWriter("fws"));
        }
        
        [TestMethod]
        public void Existing_Format_Formating_Cloud_Factory_Test()
        {
            Dictionary<string, Format> formatList = new Dictionary<string, Format>();
            formatList.Add("json", new JsonFormatter());

            IFactory factory = new CloudWriterFactory(formatList);
            WriterModel w = factory.CreateWriter("json");
            Assert.AreEqual("json", w.formatName);
        }

        [TestMethod]
        public void Non_Existing_Extension_Cloud_Factory_Formating_Test()
        {
            Dictionary<string, Format> formatList = new Dictionary<string, Format>();
            formatList.Add("json", new JsonFormatter());
            IFactory factory = new CloudWriterFactory(formatList);
            Assert.ThrowsException<KeyNotFoundException>(() => factory.CreateWriter("fws"));
        }

    }
}
