using System;
using System.Collections.Generic;
using System.Text;

using Spring.Context;
using Spring.Context.Support;

namespace WinClient
{
    public class WinClient
    {
        private static IApplicationContext applicationContext = null;

        static WinClient()
        {
            applicationContext = ContextRegistry.GetContext();
        }

        public static IApplicationContext ApplicationContext
        {
            get { return applicationContext; }
        }

    }
}
