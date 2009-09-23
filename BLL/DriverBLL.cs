using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SubSonic.Repository;
using SubSonic.Query;
using SubSonic.Linq;
using DispatchAR;
using System.Linq;

namespace BLL
    //I map my escape key in normal mode to do the :noh 
    //as well as an escape (nnoremap <esc> :noh<cr><esc>). 
    //It somehow seems logical to me to clear the highlight with escape.
{
    public class DriverBLL : BaseBLL
    {
        private IQueryable<DRIVER> qry = null;
        //private SimpleRepository repo = null;

        public DriverBLL()
            : base()
        {
            //Repo = (SimpleRepository)_applicationContext["myRepo"];
            qry = Repo.All<DRIVER>();
        }

        #region IBLL Members
        public IQueryable<DRIVER>  GetAll()
        {
            return Repo.All<DRIVER>();
        }

        public IQueryable<DRIVER>  GetById(string ID)
        {
            return  Repo.Find<DRIVER>(x=>x.DriverID == ID.ToUpper()).AsQueryable<DRIVER>();
        }

        public bool SaveOrUpdate(IQueryable<DRIVER>  entity)
        {
            return false;
        }


        public void DeleteById(string p)
        {
            Repo.Delete<DRIVER>(p);
            //throw new NotImplementedException();
        }
        #endregion
    }
}
