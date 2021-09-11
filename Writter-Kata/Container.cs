using System;
using System.Collections.Generic;
using System.Text;

namespace Writter_Kata
{
    public class Container
    {
        private Dictionary<string, IFormatable> _formatersList = new Dictionary<string, IFormatable> {
            {"json", new JsonFormater() },
            {"txt", new TxtFormater() },
            {"xml", new XmlFormater() },
            {"yml", new YmlFormater() }
        };
        private Factory _factory;
        public Container()
        {
            _factory = new Factory(_formatersList);
        }

    }
}
