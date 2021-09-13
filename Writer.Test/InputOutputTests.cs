using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Writer.Dependency.Interface;
using Writer.Dependency.Models;
using Writer.Dependency.Models.Enums;

namespace Writer.Test
{
    [TestClass]
    public class InputOutputTests
    {
        [TestMethod]
        public void TestLocalWrittingJsonOutput()
        {
            var factory = new Container("local").GetFactory();
            var writer = factory.GetWriter(FormaterOptions.Json);
            Assert.AreEqual("filename.json", writer.Write("filename"));            
        }

        [TestMethod]
        public void TestLocalWrittingPlainOutput()
        {
            var factory = new Container("local").GetFactory();
            var writer = factory.GetWriter(FormaterOptions.Plain);
            Assert.AreEqual("filename.txt", writer.Write("filename"));
        }

        [TestMethod]
        public void TestLocalWrittingXmlOutput()
        {
            var factory = new Container("local").GetFactory();
            var writer = factory.GetWriter(FormaterOptions.Xml);
            Assert.AreEqual("filename.xml", writer.Write("filename"));
        }

        [TestMethod]
        public void TestLocalWrittingYmlOutput()
        {
            var factory = new Container("local").GetFactory();
            var writer = factory.GetWriter(FormaterOptions.Yml);
            Assert.AreEqual("filename.yml", writer.Write("filename"));
        }

        [TestMethod]
        public void TestCloudWrittingJsonOutput()
        {
            var factory = new Container("cloud").GetFactory();
            var writer = factory.GetWriter(FormaterOptions.Json);
            Assert.AreEqual("filename.json", writer.Write("filename"));
        }

        [TestMethod]
        public void TestCloudWrittingPlainOutput()
        {
            var factory = new Container("cloud").GetFactory();
            var writer = factory.GetWriter(FormaterOptions.Plain);
            Assert.AreEqual("filename.txt", writer.Write("filename"));
        }

        [TestMethod]
        public void TestCloudWrittingXmlOutput()
        {
            var factory = new Container("cloud").GetFactory();
            var writer = factory.GetWriter(FormaterOptions.Xml);
            Assert.AreEqual("filename.xml", writer.Write("filename"));
        }

        [TestMethod]
        public void TestCloudWrittingYmlOutput()
        {
            var factory = new Container("cloud").GetFactory();
            var writer = factory.GetWriter(FormaterOptions.Yml);
            Assert.AreEqual("filename.yml", writer.Write("filename"));
        }
    }
}
