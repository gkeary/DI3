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
    public class CurrentDayPickupBLL : BaseBLL
    {
        private IQueryable<CurrentDayPickup> qry = null;
        //private SimpleRepository repo = null;

        public CurrentDayPickupBLL()
            : base()
        {
            //Repo = (SimpleRepository)_applicationContext["myRepo"];
            //qry = repo.All<CurrentDayPickup>();
        }

        #region IBLL Members

        public IQueryable<CurrentDayPickup> GetAll()
        {
            return Repo.All<CurrentDayPickup>();
        }

        public IQueryable<CurrentDayPickup> GetById(string ID)
        {
            //ToDo: look at making CDPDefaultRouteID not null and unique...
            return Repo.Find<CurrentDayPickup>(x => x.CDPDefaultRouteID == ID.ToUpper()).AsQueryable<CurrentDayPickup>();
        }

        public bool SaveOrUpdate(IQueryable<CurrentDayPickup> entity)
        {
            return false;
        }
        public void DeleteById(string p)
        {
            Repo.Delete<CurrentDayPickup>(p);
            //throw new NotImplementedException();
        }
        public void DeleteAll(List<CurrentDayPickup> list)
        {
            Repo.DeleteMany<CurrentDayPickup>(list);
        }


        #endregion

    }
}
