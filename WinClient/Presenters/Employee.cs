using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using BLL.Interface;

namespace WinClient.Presenters
{
    public class Driver : IPresenter
    {
        private IBLL driverBLL = null;

        public Driver()
        {
            driverBLL = (IBLL)WinClient.ApplicationContext["DriverBLL"];
        }

        #region IPresenter Members

        public DataTable GetData(string ID)
        {
            if (ID == null || ID.Length == 0 )
            {
                return driverBLL.GetAll();
            }
            else
            {
                return driverBLL.GetById(ID);
            }
        }
       

        public bool SaveOrUpdate(DataTable entity)
        {
            return driverBLL.SaveOrUpdate(entity);
        }

        #endregion
    }
}
