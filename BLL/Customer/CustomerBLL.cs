using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
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
        private IQueryable<CUSTOMER> qry = null;
        private SimpleRepository repo;

        public CustomerBLL() : base()
        {
             repo = (SimpleRepository) _applicationContext["myRepo"];
			qry = repo.All<CUSTOMER>(); 
        }

        #region Members

        public IQueryable<CUSTOMER> GetAll()
        {
            return repo.All<CUSTOMER>();
        }

        public IQueryable<CUSTOMER> GetById(string ID)
        {
            return  repo.Find<CUSTOMER>(x=>x.CustomerID == ID.ToUpper()).AsQueryable<CUSTOMER>();
        }

        public bool SaveOrUpdate(List<CUSTOMER> entity)
        {
            return true;
        }

        #endregion
    }
}
