using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Writer.interfaces;
using Writer.models;
using Writer.services;
using Microsoft.Extensions.DependencyInjection;

namespace WriterTest
{
    [TestClass]
    public class Container_Test
    {
        [TestMethod]
        public void New_Local_Factory_Container_Is_Service_Provider_Test()
        {
            var localFactoryService = Container.Build(FactoryType.Local);
            Assert.IsInstanceOfType(localFactoryService, typeof(IServiceProvider));
        }

        [TestMethod]
        public void New_Cloud_Factory_Container_Is_Service_Provider_Test()
        {
            var cloudFactoryService = Container.Build(FactoryType.Cloud);
            Assert.IsInstanceOfType(cloudFactoryService, typeof(IServiceProvider));
        }

        [TestMethod]
        public void New_Writer_From_Local_Factory_Service_Exists_Test()
        {
            var localFactoryService = Container.Build(FactoryType.Local);
            var writer = localFactoryService.GetService<IFactory>().CreateWriter("json");
            Assert.IsNotNull(writer);
            Assert.IsInstanceOfType(writer, typeof(WriterModel));
        }

        [TestMethod]
        public void New_Writer_From_Cloud_Factory_Service_Exists_Test()
        {
            var cloudFactoryService = Container.Build(FactoryType.Cloud);
            var writer = cloudFactoryService.GetService<IFactory>().CreateWriter("json");
            Assert.IsNotNull(writer);
            Assert.IsInstanceOfType(writer, typeof(WriterModel));
        }

    }
}
