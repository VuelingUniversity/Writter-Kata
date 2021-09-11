using System;
using System.Collections.Generic;
using System.Text;

namespace Writter_Kata
{
    public class Container
    {
        public Dictionary<string, IFormatable> FormatersList = new Dictionary<string, IFormatable> {
            {"json", new JsonFormater() },
            {"txt", new TxtFormater() },
            {"xml", new XmlFormater() },
            {"yml", new YmlFormater() }
        };
        public Factory Factory;
        public Container()
        {
            Factory = new Factory(FormatersList);
        }

    }
}
