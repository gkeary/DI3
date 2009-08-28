using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using BLL.Interface;

namespace WinClient.Presenters
{
    public class Employee : IPresenter
    {
        private IBLL employeeBLL = null;

        public Employee()
        {
            employeeBLL = (IBLL)WinClient.ApplicationContext["EmployeeBLL"];
        }

        #region IPresenter Members

        public DataTable GetData(string ID)
        {
            if (ID == null || ID.Length == 0 )
            {
                return employeeBLL.GetAll();
            }
            else
            {
                return employeeBLL.GetById(ID);
            }
        }
       

        public bool SaveOrUpdate(DataTable entity)
        {
            return employeeBLL.SaveOrUpdate(entity);
        }

        #endregion
    }
}
