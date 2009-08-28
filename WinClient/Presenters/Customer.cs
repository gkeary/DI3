using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using BLL.Interface;

namespace WinClient.Presenters
{
    public class Customer : IPresenter
    {
        private IBLL customerBLL = null;
        
        public Customer()
        {
            customerBLL = (IBLL) WinClient.ApplicationContext["CustomerBLL"];
        }

        #region IPresenter Members

        public DataTable GetData(string ID)
        {
            if (ID == null || ID.Length == 0)
            {
                return customerBLL.GetAll();
            }
            else
            {
                return customerBLL.GetById(ID);
            }
        }
       

        public bool SaveOrUpdate(DataTable entity)
        {
            return customerBLL.SaveOrUpdate(entity);
        }

        #endregion
    }
}
