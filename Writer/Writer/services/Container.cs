using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Writer.interfaces;

namespace Writer.services
{
    public static class Container
    {

        public static IServiceProvider Build()
        {
            var service = new ServiceCollection()
                .AddSingleton<IFactory, Factory>()
                .BuildServiceProvider();
            return service;
        }

    }
}
