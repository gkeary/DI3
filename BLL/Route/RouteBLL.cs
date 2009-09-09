using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DispatchAR;
using SubSonic.Repository;
using SubSonic.Query;

namespace BLL.Route
{
    class RouteBLL : BaseBLL
    {
        private IQueryable<DispatchAR.Route> qry = null;
        private SimpleRepository repo;
        public RouteBLL()
            : base()
        {
            repo = (SimpleRepository)_applicationContext["myRepo"];
            qry = repo.All<DispatchAR.Route>();
        }

        #region Members

        public IQueryable<DispatchAR.Route> GetAll()
        {
            return repo.All<DispatchAR.Route>();
        }

        public IQueryable<DispatchAR.Route> GetById(string ID)
        {
            return repo.Find<DispatchAR.Route>(x => x.RouteID == ID.ToUpper()).AsQueryable<DispatchAR.Route>();
        }

        public bool SaveOrUpdate(List<DispatchAR.Route> entity)
        {
            return true;
        }

        #endregion
    }
}



