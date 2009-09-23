using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DispatchAR;
using SubSonic.Repository;
using SubSonic.Query;

namespace BLL
{
    public class RouteBLL : BaseBLL
    {
        private IQueryable<DispatchAR.Route> qry = null;
        //private SimpleRepository repo;
        public RouteBLL()
            : base()
        {
            //Repo = (SimpleRepository)_applicationContext["myRepo"];
            qry = Repo.All<DispatchAR.Route>();
        }

        #region Members

        public IQueryable<DispatchAR.Route> GetAll()
        {
            return Repo.All<DispatchAR.Route>();
        }

        public IQueryable<DispatchAR.Route> GetById(string ID)
        {
            return Repo.Find<DispatchAR.Route>(x => x.RouteID == ID.ToUpper()).AsQueryable<DispatchAR.Route>();
        }

        public bool SaveOrUpdate(List<DispatchAR.Route> entity)
        {
            return true;
        }


        public void SetBlank(string DriverID)
        {
            //var q = from rl in GetAll()
            //        where rl.DefaultDriverID == DriverID
            //        select rl;
            //var items = q.ToList<Route>();
            //Repo.UpdateMany<DispatchAR.Route>(items);
            // or... (looks like they both work) 
            var items1 = GetAll().Where<Route>(x => x.DefaultDriverID == DriverID);
            Repo.UpdateMany<Route>(items1);
            
        }
        #endregion
    }
}