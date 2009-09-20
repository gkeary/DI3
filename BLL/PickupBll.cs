using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DispatchAR;
using SubSonic.Repository;
using SubSonic.Query;
//using SubSonic.Linq;
using System.Linq;

namespace BLL
    //I map my escape key in normal mode to do the :noh 
    //as well as an escape (nnoremap <esc> :noh<cr><esc>). 
    //It somehow seems logical to me to clear the highlight with escape.
{
public class PickupBLL: BaseBLL
    {
       /// <summary>
       ///
       /// </summary>
        private IQueryable<Pickup> qry = null;
        //private SimpleRepository repo = null;

        public PickupBLL() : base()
        {
             Repo = (SimpleRepository) _applicationContext["myRepo"];
			qry = Repo.All<Pickup>(); 
        }

        #region Members

        public IQueryable<Pickup>  GetAll()
        {
            return Repo.All<Pickup>(); 
        }

        public IQueryable<Pickup>  GetById(string CustomerID)
        {
            return  Repo.Find<Pickup>(x=>x.CustomerID == CustomerID.ToUpper()).AsQueryable<Pickup>();
        }

        public bool SaveOrUpdate(IQueryable<Pickup>  entity)
        {
            return true;
        }

        #endregion
    }
}

