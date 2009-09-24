using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DispatchAR;
using SubSonic.Repository;
using SubSonic.Query;
using System.Linq;

namespace BLL
{
    public class CustomerBLL : BaseBLL
    {
       /// <summary>
       ///
       /// </summary>
        private IQueryable<CUSTOMER> qry = null;
        //private SimpleRepository repo;

        public CustomerBLL() : base()
        {
             Repo = (SimpleRepository) _applicationContext["myRepo"];
			qry = Repo.All<CUSTOMER>(); 
        }

        #region Members

        public IQueryable<CUSTOMER> GetAll()
        {
            return Repo.All<CUSTOMER>();
        }

        public IQueryable<CUSTOMER> GetById(string ID)
        {
            return  Repo.Find<CUSTOMER>(x=>x.CustomerID == ID.ToUpper()).AsQueryable<CUSTOMER>();
        }

        public bool SaveOrUpdate(List<CUSTOMER> entity)
        {
            return true;
        }
        /**************  here is vCustomerList
        ALTER VIEW [dbo].[vCustomerList]
        AS
        SELECT     TOP (100) PERCENT 
                CustomerID, 
                CustomerID + CASE WHEN len(CustomerID) = 3 THEN '       => ' 
         * 
         * 
                                  WHEN len(CustomerID) = 4 THEN '     => ' 
                                  WHEN len(CustomerID) = 5 THEN '   => ' 
                                  WHEN len(CustomerID) = 6 THEN ' => ' 
                                  WHEN len(CustomerID) = 7 THEN '=> ' 
                                  ELSE                          '-> ' END 
                                      + CustomerName + ' @ ' 
                                      + City AS CustomerNameAndCity, 
                 Address1, Address2, 
                 City, State, 
                 Phone, Contact, ClosingTime, Comment, 
                 DefaultRouteID, CustomerName, CustomerTableID
         FROM         dbo.CUSTOMER
         ORDER BY CustomerName
        ************************************************/
        public List<string> GetCustStringList()
        {
            var clist = new List<string>();
            
            var list = this.GetAll();
            foreach(var ll in list) {
                clist.Add(BuildString(ll.CustomerID, 
                            ll.CustomerName, 
                            ll.City));
            };
            return clist;

        }
    private static string BuildString(string keystring, string namestring, string citystring) {
       var sb = new StringBuilder();
       sb.Append(keystring);
       switch (keystring.Length) {
           case 3: sb.Append("       => "); break;
           case 4: sb.Append("      => " ); break;
           case 5: sb.Append("     => "  ); break;
           case 6: sb.Append("    => "   ); break;
           case 7: sb.Append("   => "    ); break;
           default: sb.Append("=> " ); break;
        };
        sb.Append(namestring + " @ " + citystring);
        return sb.ToString();                                    
}

        #endregion

    public  List<CUSTOMER> GetCustomerList()
    {
       return (List<CUSTOMER>) GetAll();
    }
    }
}
