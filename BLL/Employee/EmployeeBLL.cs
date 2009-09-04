using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAL.Interface;
using SubSonic.Repository;
using SubSonic.Query;
using SubSonic.Linq;
using DispatchAR;
using System.Linq;

namespace BLL.Employee
{
    public class EmployeeBLL : BaseBLL
    {
        private IDAL _employeeDAL = null;
        private IQueryable<DRIVER> qry = null;

        public EmployeeBLL()
            : base()
        {
            SimpleRepository repo = (SimpleRepository)_applicationContext["myRepo"];
            qry = repo.All<DRIVER>();
            //_employeeDAL = (IDAL)_applicationContext["EmployeeDAL"];
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
