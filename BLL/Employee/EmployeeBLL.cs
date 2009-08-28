using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAL.Interface;

namespace BLL.Employee
{
    public class EmployeeBLL : BaseBLL
    {
        private IDAL _employeeDAL = null;

        public EmployeeBLL()
            : base()
        {
            _employeeDAL = (IDAL)_applicationContext["EmployeeDAL"];
        }

        #region IBLL Members

        public override DataTable GetAll()
        {
            return _employeeDAL.GetAll();
        }

        public override DataTable GetById(string ID)
        {
            return _employeeDAL.GetById(ID);
        }

        public override bool SaveOrUpdate(DataTable entity)
        {
            return _employeeDAL.SaveOrUpdate(entity);
        }

        #endregion
    }
}
