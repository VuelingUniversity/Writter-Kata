using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Writer.Dependency.Interface;
using Writer.Dependency.Models;

namespace Writer.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IFormater formater = GetFormater();
            var Writer = new Writer.Dependency.Models.Writer(formater);
            var res = Writer.Write(string.Empty);
            
        }

        private IFormater GetFormater()
        {
            throw new NotImplementedException();
        }
    }
}
