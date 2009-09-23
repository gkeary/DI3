using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SubSonic.Repository;
using SubSonic.Query;
using SubSonic.Linq;
using DispatchAR;


namespace BLL.CurrentDay
{
    public class CurrentDayRouteBLL : BaseBLL
    {
        private IQueryable<CurrentDayRoute> qry = null;
        //private SimpleRepository repo = null;

        public CurrentDayRouteBLL() 
            : base()
        {
            Repo = (SimpleRepository)_applicationContext["myRepo"];
            qry = Repo.All<CurrentDayRoute>();
        }

        #region IBLL Members

        public IQueryable<CurrentDayRoute> GetAll()
        {
            return Repo.All<CurrentDayRoute>();
        }

        public IQueryable<CurrentDayRoute> GetById(string ID)
        {
            //ToDo: look at making CDPDefaultRouteID not null and unique...
            return Repo.Find<CurrentDayRoute>(x => x.CDRRouteID == ID.ToUpper()).AsQueryable<CurrentDayRoute>();
        }

        public bool SaveOrUpdate(IQueryable<CurrentDayRoute> entity)
        {
            return false;
        }
        public void DeleteById(string p)
        {
            Repo.Delete<CurrentDayRoute>(p);
        }
        public void DeleteAll(List<CurrentDayRoute> list)
        {
            Repo.DeleteMany<CurrentDayRoute>(list);
        }
        #endregion

    }
}
