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
    public class PostingBLL : BaseBLL
    {
        private IQueryable<Posting> qry = null;
        //private SimpleRepository repo = null;

        public PostingBLL()
            : base()
        {
            //Repo = (SimpleRepository)_applicationContext["myRepo"];
            qry = Repo.All<Posting>();
        }

        #region IBLL Members

        public IQueryable<Posting> GetAll()
        {
            return Repo.All<Posting>();
        }
        
        public IQueryable<Posting> GetById(int ID)
        {
            return Repo.Find<Posting>(x => x.PostingID == ID).AsQueryable<Posting>();
        }

        public bool SaveOrUpdate(IQueryable<Posting> entity)
        {
            return false;
        }

        #endregion
        public void DeleteById(string p)
        {
            Repo.Delete<Posting>(p);
        }
        public void DeleteAll(List<Posting> list)
        {
            Repo.DeleteMany<Posting>(list);
        }
    }
}
