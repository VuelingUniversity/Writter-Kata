using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Writter.Interfaces;

namespace Writter.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IFormater formater = GetFormater();
            var Writer = new Writter.Models.Writer(formater);
            var res = Writer.Write("");

        }

        private IFormater GetFormater()
        {
            throw new NotImplementedException();
        }
    }
    }
