using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using BLL.Interface;
using Spring.Core;
using Spring.Context;
using Spring.Context.Support;

namespace BLL
{
    public abstract class BaseBLL : IBLL
    {
        protected IApplicationContext _applicationContext = null;

        public BaseBLL()
        {
            _applicationContext = ContextRegistry.GetContext();
        }

        #region IBLL Members

        public abstract DataTable GetAll();

        public abstract DataTable GetById(string ID);

        public abstract bool SaveOrUpdate(DataTable entity);

        #endregion
    }
}
