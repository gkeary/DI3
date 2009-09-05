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

        public CUSTOMER GetById(string ID)
        {
            var q = from c in repo.All<CUSTOMER>()
                    where c.CustomerID == ID
                    select c;
            return q.ElementAtOrDefault<CUSTOMER>(0);

        }

        public bool SaveOrUpdate(List<CUSTOMER> entity)
        {
            return true;
        }

        #endregion
    }
}
