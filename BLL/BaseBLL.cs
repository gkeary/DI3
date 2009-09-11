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
        public SimpleRepository Repo { get; set; } 

        public BaseBLL()
        {
            _applicationContext = ContextRegistry.GetContext();
            Repo = (SimpleRepository)_applicationContext["myRepo"];
        }
    }
}
