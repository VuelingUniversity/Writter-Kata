using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

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
        public IFactoryable Factory;
        
        public Container(int option )
        {
            Factory = IsCloud(option);
        }

        private IFactoryable IsCloud(int option)
        {
            if (option == 2)
            {
                return new FactoryCloud(FormatersList);
            } else if(option == 1)
            {
                return new Factory(FormatersList);
            }
            throw new Exception("Invalid option");
        }



    }
}
