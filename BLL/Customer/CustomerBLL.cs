using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAL.Interface;
using DispatchAR;
using SubSonic.Repository;
using SubSonic.Query;
using System.Linq;

namespace BLL.Customer
{
    public class CustomerBLL : BaseBLL
    {
       /// <summary>
       ///
       /// </summary>
 private IDAL _customerDAL = null;
        private IQueryable<CUSTOMER> qry = null;
        //private DispatchAR.CUSTOMERSTable tbl ;

        public CustomerBLL() : base()
        {
            SimpleRepository repo = (SimpleRepository) _applicationContext["myRepo"];
			qry = repo.All<CUSTOMER>(); 
        }

        #region IBLL Members

        public override DataTable GetAll()
        {
            return _customerDAL.GetAll();
        }

        public override DataTable GetById(string ID)
        {
            return _customerDAL.GetById(ID);
        }

        public override bool SaveOrUpdate(DataTable entity)
        {
            return _customerDAL.SaveOrUpdate(entity);
        }

        #endregion
    }
}
