using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SubSonic.Repository;
using SubSonic.Query;
using SubSonic.Linq;
using DispatchAR;


namespace BLL.CDPCDR
{
    public class CurrentDayRouteBLL : BaseBLL
    {
        private IQueryable<CurrentDayRoute> qry = null;
        private SimpleRepository repo = null;

        public CurrentDayRouteBLL() 
            : base()
        {
            repo = (SimpleRepository)_applicationContext["myRepo"];
            qry = repo.All<CurrentDayRoute>();
        }

        #region IBLL Members

        public IQueryable<CurrentDayRoute> GetAll()
        {
            return repo.All<CurrentDayRoute>();
        }

        public IQueryable<CurrentDayRoute> GetById(string ID)
        {
            //ToDo: look at making CDPDefaultRouteID not null and unique...
            return repo.Find<CurrentDayRoute>(x => x.CDRRouteID == ID.ToUpper()).AsQueryable<CurrentDayRoute>();
        }

        public bool SaveOrUpdate(IQueryable<CurrentDayRoute> entity)
        {
            return false;
        }

        #endregion

    }
}
