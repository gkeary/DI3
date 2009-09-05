using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using Spring.Core;
using Spring.Context;
using Spring.Context.Support;
using SubSonic.Repository;

namespace BLL
{
    public abstract class BaseBLL 
    {
        protected IApplicationContext _applicationContext = null;

        public BaseBLL()
        {
            _applicationContext = ContextRegistry.GetContext();
        }
    }
}
