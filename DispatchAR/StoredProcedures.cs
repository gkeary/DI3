


  
using System;
using SubSonic;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace DispatchAR{
	public partial class DispatchDB{

        public StoredProcedure p_refresh_syncids(){
            StoredProcedure sp=new StoredProcedure("p_refresh_syncids",this.Provider);
            return sp;
        }
        public StoredProcedure p_update_customer(int RC,int CustomerTableID,string NewCustomerID,string customername,string defaultrouteid,string customersyncid,string address1,string address2,string city,string state,string phone,string closingtime,string contact,string comment){
            StoredProcedure sp=new StoredProcedure("p_update_customer",this.Provider);
            sp.Command.AddParameter("RC",RC,DbType.Int32);
            sp.Command.AddParameter("CustomerTableID",CustomerTableID,DbType.Int32);
            sp.Command.AddParameter("NewCustomerID",NewCustomerID,DbType.AnsiString);
            sp.Command.AddParameter("customername",customername,DbType.AnsiString);
            sp.Command.AddParameter("defaultrouteid",defaultrouteid,DbType.AnsiString);
            sp.Command.AddParameter("customersyncid",customersyncid,DbType.AnsiString);
            sp.Command.AddParameter("address1",address1,DbType.AnsiString);
            sp.Command.AddParameter("address2",address2,DbType.AnsiString);
            sp.Command.AddParameter("city",city,DbType.AnsiString);
            sp.Command.AddParameter("state",state,DbType.AnsiString);
            sp.Command.AddParameter("phone",phone,DbType.AnsiString);
            sp.Command.AddParameter("closingtime",closingtime,DbType.AnsiString);
            sp.Command.AddParameter("contact",contact,DbType.AnsiString);
            sp.Command.AddParameter("comment",comment,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure SelectFromVDefaultRoutes(){
            StoredProcedure sp=new StoredProcedure("SelectFromVDefaultRoutes",this.Provider);
            return sp;
        }
	
	}
	
}
 