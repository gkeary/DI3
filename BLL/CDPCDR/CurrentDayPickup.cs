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
    public class CurrentDayPickupBLL : BaseBLL
    {
        private IQueryable<CurrentDayPickup> qry = null;
        private SimpleRepository repo = null;

        public CurrentDayPickupBLL()
            : base()
        {
            repo = (SimpleRepository)_applicationContext["myRepo"];
            qry = repo.All<CurrentDayPickup>();
        }

        #region IBLL Members

        public IQueryable<CurrentDayPickup> GetAll()
        {
            return repo.All<CurrentDayPickup>();
        }

        public IQueryable<CurrentDayPickup> GetById(string ID)
        {
            //ToDo: look at making CDPDefaultRouteID not null and unique...
            return repo.Find<CurrentDayPickup>(x => x.CDPDefaultRouteID == ID.ToUpper()).AsQueryable<CurrentDayPickup>();
        }

        public bool SaveOrUpdate(IQueryable<CurrentDayPickup> entity)
        {
            return false;
        }

        #endregion

    }
}
