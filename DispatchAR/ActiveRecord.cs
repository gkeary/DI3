


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SubSonic.DataProviders;
using SubSonic.Extensions;
using System.Linq.Expressions;
using SubSonic.Schema;
using System.Collections;
using SubSonic;
using SubSonic.Repository;
using System.ComponentModel;
using System.Data.Common;

namespace DispatchAR
{
    
    
    /// <summary>
    /// A class which represents the CUSTOMERS table in the Dispatch Database.
    /// </summary>
    public partial class CUSTOMER: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<CUSTOMER> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<CUSTOMER>(new DispatchAR.DispatchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<CUSTOMER> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(CUSTOMER item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                CUSTOMER item=new CUSTOMER();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<CUSTOMER> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        DispatchAR.DispatchDB _db;
        public CUSTOMER(string connectionString, string providerName) {

            _db=new DispatchAR.DispatchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                CUSTOMER.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CUSTOMER>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public CUSTOMER(){
             _db=new DispatchAR.DispatchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public CUSTOMER(Expression<Func<CUSTOMER, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<CUSTOMER> GetRepo(string connectionString, string providerName){
            DispatchAR.DispatchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new DispatchAR.DispatchDB();
            }else{
                db=new DispatchAR.DispatchDB(connectionString, providerName);
            }
            IRepository<CUSTOMER> _repo;
            
            if(db.TestMode){
                CUSTOMER.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CUSTOMER>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<CUSTOMER> GetRepo(){
            return GetRepo("","");
        }
        
        public static CUSTOMER SingleOrDefault(Expression<Func<CUSTOMER, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            CUSTOMER single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static CUSTOMER SingleOrDefault(Expression<Func<CUSTOMER, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            CUSTOMER single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<CUSTOMER, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<CUSTOMER, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<CUSTOMER> Find(Expression<Func<CUSTOMER, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<CUSTOMER> Find(Expression<Func<CUSTOMER, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<CUSTOMER> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<CUSTOMER> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<CUSTOMER> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<CUSTOMER> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<CUSTOMER> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<CUSTOMER> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CustomerID";
        }

        public object KeyValue()
        {
            return this.CustomerID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<string>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CustomerID.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(CUSTOMER)){
                CUSTOMER compare=(CUSTOMER)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.CustomerID.ToString();
        }

        public string DescriptorColumn() {
            return "CustomerID";
        }
        public static string GetKeyColumn()
        {
            return "CustomerID";
        }        
        public static string GetDescriptorColumn()
        {
            return "CustomerID";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        string _CustomerID;
        public string CustomerID
        {
            get { return _CustomerID; }
            set
            {
                if(_CustomerID!=value){
                    _CustomerID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CustomerID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CustomerName;
        public string CustomerName
        {
            get { return _CustomerName; }
            set
            {
                if(_CustomerName!=value){
                    _CustomerName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CustomerName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Address1;
        public string Address1
        {
            get { return _Address1; }
            set
            {
                if(_Address1!=value){
                    _Address1=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Address1");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Address2;
        public string Address2
        {
            get { return _Address2; }
            set
            {
                if(_Address2!=value){
                    _Address2=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Address2");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _City;
        public string City
        {
            get { return _City; }
            set
            {
                if(_City!=value){
                    _City=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="City");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _State;
        public string State
        {
            get { return _State; }
            set
            {
                if(_State!=value){
                    _State=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="State");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set
            {
                if(_Phone!=value){
                    _Phone=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Phone");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Contact;
        public string Contact
        {
            get { return _Contact; }
            set
            {
                if(_Contact!=value){
                    _Contact=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Contact");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ClosingTime;
        public string ClosingTime
        {
            get { return _ClosingTime; }
            set
            {
                if(_ClosingTime!=value){
                    _ClosingTime=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ClosingTime");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Comment;
        public string Comment
        {
            get { return _Comment; }
            set
            {
                if(_Comment!=value){
                    _Comment=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Comment");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _DefaultRouteID;
        public string DefaultRouteID
        {
            get { return _DefaultRouteID; }
            set
            {
                if(_DefaultRouteID!=value){
                    _DefaultRouteID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="DefaultRouteID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CustomerSyncID;
        public string CustomerSyncID
        {
            get { return _CustomerSyncID; }
            set
            {
                if(_CustomerSyncID!=value){
                    _CustomerSyncID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CustomerSyncID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Terminal;
        public string Terminal
        {
            get { return _Terminal; }
            set
            {
                if(_Terminal!=value){
                    _Terminal=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Terminal");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _InfoString;
        public string InfoString
        {
            get { return _InfoString; }
            set
            {
                if(_InfoString!=value){
                    _InfoString=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="InfoString");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<CUSTOMER, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Postings table in the Dispatch Database.
    /// </summary>
    public partial class Posting: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Posting> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Posting>(new DispatchAR.DispatchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Posting> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Posting item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Posting item=new Posting();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Posting> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        DispatchAR.DispatchDB _db;
        public Posting(string connectionString, string providerName) {

            _db=new DispatchAR.DispatchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Posting.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Posting>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Posting(){
             _db=new DispatchAR.DispatchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Posting(Expression<Func<Posting, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Posting> GetRepo(string connectionString, string providerName){
            DispatchAR.DispatchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new DispatchAR.DispatchDB();
            }else{
                db=new DispatchAR.DispatchDB(connectionString, providerName);
            }
            IRepository<Posting> _repo;
            
            if(db.TestMode){
                Posting.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Posting>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Posting> GetRepo(){
            return GetRepo("","");
        }
        
        public static Posting SingleOrDefault(Expression<Func<Posting, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Posting single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Posting SingleOrDefault(Expression<Func<Posting, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Posting single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Posting, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Posting, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Posting> Find(Expression<Func<Posting, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Posting> Find(Expression<Func<Posting, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Posting> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Posting> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Posting> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Posting> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Posting> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Posting> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "PostingID";
        }

        public object KeyValue()
        {
            return this.PostingID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.DataType.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Posting)){
                Posting compare=(Posting)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.PostingID;
        }
        
        public string DescriptorValue()
        {
            return this.DataType.ToString();
        }

        public string DescriptorColumn() {
            return "DataType";
        }
        public static string GetKeyColumn()
        {
            return "PostingID";
        }        
        public static string GetDescriptorColumn()
        {
            return "DataType";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _PostingID;
        public int PostingID
        {
            get { return _PostingID; }
            set
            {
                if(_PostingID!=value){
                    _PostingID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PostingID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _DataType;
        public string DataType
        {
            get { return _DataType; }
            set
            {
                if(_DataType!=value){
                    _DataType=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="DataType");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _key;
        public int? key
        {
            get { return _key; }
            set
            {
                if(_key!=value){
                    _key=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="key");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _DefaultRouteId;
        public string DefaultRouteId
        {
            get { return _DefaultRouteId; }
            set
            {
                if(_DefaultRouteId!=value){
                    _DefaultRouteId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="DefaultRouteId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _PreviousRouteID;
        public string PreviousRouteID
        {
            get { return _PreviousRouteID; }
            set
            {
                if(_PreviousRouteID!=value){
                    _PreviousRouteID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PreviousRouteID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _NumberOfPendingUpdates;
        public int? NumberOfPendingUpdates
        {
            get { return _NumberOfPendingUpdates; }
            set
            {
                if(_NumberOfPendingUpdates!=value){
                    _NumberOfPendingUpdates=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="NumberOfPendingUpdates");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Originator;
        public string Originator
        {
            get { return _Originator; }
            set
            {
                if(_Originator!=value){
                    _Originator=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Originator");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _IsDragNDrop;
        public bool? IsDragNDrop
        {
            get { return _IsDragNDrop; }
            set
            {
                if(_IsDragNDrop!=value){
                    _IsDragNDrop=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="IsDragNDrop");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Posting, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the CurrentDayPickups table in the Dispatch Database.
    /// </summary>
    public partial class CurrentDayPickup: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<CurrentDayPickup> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<CurrentDayPickup>(new DispatchAR.DispatchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<CurrentDayPickup> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(CurrentDayPickup item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                CurrentDayPickup item=new CurrentDayPickup();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<CurrentDayPickup> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        DispatchAR.DispatchDB _db;
        public CurrentDayPickup(string connectionString, string providerName) {

            _db=new DispatchAR.DispatchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                CurrentDayPickup.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CurrentDayPickup>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public CurrentDayPickup(){
             _db=new DispatchAR.DispatchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public CurrentDayPickup(Expression<Func<CurrentDayPickup, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<CurrentDayPickup> GetRepo(string connectionString, string providerName){
            DispatchAR.DispatchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new DispatchAR.DispatchDB();
            }else{
                db=new DispatchAR.DispatchDB(connectionString, providerName);
            }
            IRepository<CurrentDayPickup> _repo;
            
            if(db.TestMode){
                CurrentDayPickup.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CurrentDayPickup>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<CurrentDayPickup> GetRepo(){
            return GetRepo("","");
        }
        
        public static CurrentDayPickup SingleOrDefault(Expression<Func<CurrentDayPickup, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            CurrentDayPickup single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static CurrentDayPickup SingleOrDefault(Expression<Func<CurrentDayPickup, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            CurrentDayPickup single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<CurrentDayPickup, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<CurrentDayPickup, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<CurrentDayPickup> Find(Expression<Func<CurrentDayPickup, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<CurrentDayPickup> Find(Expression<Func<CurrentDayPickup, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<CurrentDayPickup> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<CurrentDayPickup> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<CurrentDayPickup> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<CurrentDayPickup> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<CurrentDayPickup> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<CurrentDayPickup> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CurrentDayPickupID";
        }

        public object KeyValue()
        {
            return this.CurrentDayPickupID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CDPDefaultRouteID.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(CurrentDayPickup)){
                CurrentDayPickup compare=(CurrentDayPickup)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.CurrentDayPickupID;
        }
        
        public string DescriptorValue()
        {
            return this.CDPDefaultRouteID.ToString();
        }

        public string DescriptorColumn() {
            return "CDPDefaultRouteID";
        }
        public static string GetKeyColumn()
        {
            return "CurrentDayPickupID";
        }        
        public static string GetDescriptorColumn()
        {
            return "CDPDefaultRouteID";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _CurrentDayPickupID;
        public int CurrentDayPickupID
        {
            get { return _CurrentDayPickupID; }
            set
            {
                if(_CurrentDayPickupID!=value){
                    _CurrentDayPickupID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CurrentDayPickupID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDPDefaultRouteID;
        public string CDPDefaultRouteID
        {
            get { return _CDPDefaultRouteID; }
            set
            {
                if(_CDPDefaultRouteID!=value){
                    _CDPDefaultRouteID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPDefaultRouteID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDPPreviousRouteID;
        public string CDPPreviousRouteID
        {
            get { return _CDPPreviousRouteID; }
            set
            {
                if(_CDPPreviousRouteID!=value){
                    _CDPPreviousRouteID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPPreviousRouteID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _CDPPickupDate;
        public DateTime? CDPPickupDate
        {
            get { return _CDPPickupDate; }
            set
            {
                if(_CDPPickupDate!=value){
                    _CDPPickupDate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPPickupDate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDPCustomerID;
        public string CDPCustomerID
        {
            get { return _CDPCustomerID; }
            set
            {
                if(_CDPCustomerID!=value){
                    _CDPCustomerID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPCustomerID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDPDriverName;
        public string CDPDriverName
        {
            get { return _CDPDriverName; }
            set
            {
                if(_CDPDriverName!=value){
                    _CDPDriverName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPDriverName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDPDriverMessage;
        public string CDPDriverMessage
        {
            get { return _CDPDriverMessage; }
            set
            {
                if(_CDPDriverMessage!=value){
                    _CDPDriverMessage=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPDriverMessage");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDPRouteName;
        public string CDPRouteName
        {
            get { return _CDPRouteName; }
            set
            {
                if(_CDPRouteName!=value){
                    _CDPRouteName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPRouteName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDPCustomerName;
        public string CDPCustomerName
        {
            get { return _CDPCustomerName; }
            set
            {
                if(_CDPCustomerName!=value){
                    _CDPCustomerName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPCustomerName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDPComment;
        public string CDPComment
        {
            get { return _CDPComment; }
            set
            {
                if(_CDPComment!=value){
                    _CDPComment=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPComment");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _CDPDispatched;
        public bool CDPDispatched
        {
            get { return _CDPDispatched; }
            set
            {
                if(_CDPDispatched!=value){
                    _CDPDispatched=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPDispatched");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _CDPDispatchTime;
        public DateTime? CDPDispatchTime
        {
            get { return _CDPDispatchTime; }
            set
            {
                if(_CDPDispatchTime!=value){
                    _CDPDispatchTime=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPDispatchTime");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDPNotes;
        public string CDPNotes
        {
            get { return _CDPNotes; }
            set
            {
                if(_CDPNotes!=value){
                    _CDPNotes=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPNotes");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDPStation;
        public string CDPStation
        {
            get { return _CDPStation; }
            set
            {
                if(_CDPStation!=value){
                    _CDPStation=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPStation");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _CDPDeleted;
        public bool CDPDeleted
        {
            get { return _CDPDeleted; }
            set
            {
                if(_CDPDeleted!=value){
                    _CDPDeleted=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPDeleted");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Terminal;
        public string Terminal
        {
            get { return _Terminal; }
            set
            {
                if(_Terminal!=value){
                    _Terminal=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Terminal");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDPEditedBy;
        public string CDPEditedBy
        {
            get { return _CDPEditedBy; }
            set
            {
                if(_CDPEditedBy!=value){
                    _CDPEditedBy=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDPEditedBy");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<CurrentDayPickup, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the DRIVERS table in the Dispatch Database.
    /// </summary>
    public partial class DRIVER: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<DRIVER> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<DRIVER>(new DispatchAR.DispatchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<DRIVER> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(DRIVER item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                DRIVER item=new DRIVER();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<DRIVER> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        DispatchAR.DispatchDB _db;
        public DRIVER(string connectionString, string providerName) {

            _db=new DispatchAR.DispatchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                DRIVER.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<DRIVER>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public DRIVER(){
             _db=new DispatchAR.DispatchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public DRIVER(Expression<Func<DRIVER, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<DRIVER> GetRepo(string connectionString, string providerName){
            DispatchAR.DispatchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new DispatchAR.DispatchDB();
            }else{
                db=new DispatchAR.DispatchDB(connectionString, providerName);
            }
            IRepository<DRIVER> _repo;
            
            if(db.TestMode){
                DRIVER.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<DRIVER>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<DRIVER> GetRepo(){
            return GetRepo("","");
        }
        
        public static DRIVER SingleOrDefault(Expression<Func<DRIVER, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            DRIVER single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static DRIVER SingleOrDefault(Expression<Func<DRIVER, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            DRIVER single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<DRIVER, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<DRIVER, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<DRIVER> Find(Expression<Func<DRIVER, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<DRIVER> Find(Expression<Func<DRIVER, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<DRIVER> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<DRIVER> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<DRIVER> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<DRIVER> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<DRIVER> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<DRIVER> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "DriverTableID";
        }

        public object KeyValue()
        {
            return this.DriverTableID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.DriverID.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(DRIVER)){
                DRIVER compare=(DRIVER)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.DriverTableID;
        }
        
        public string DescriptorValue()
        {
            return this.DriverID.ToString();
        }

        public string DescriptorColumn() {
            return "DriverID";
        }
        public static string GetKeyColumn()
        {
            return "DriverTableID";
        }        
        public static string GetDescriptorColumn()
        {
            return "DriverID";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _DriverTableID;
        public int DriverTableID
        {
            get { return _DriverTableID; }
            set
            {
                if(_DriverTableID!=value){
                    _DriverTableID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="DriverTableID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _DriverID;
        public string DriverID
        {
            get { return _DriverID; }
            set
            {
                if(_DriverID!=value){
                    _DriverID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="DriverID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set
            {
                if(_LastName!=value){
                    _LastName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LastName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if(_FirstName!=value){
                    _FirstName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="FirstName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _MiddleInitial;
        public string MiddleInitial
        {
            get { return _MiddleInitial; }
            set
            {
                if(_MiddleInitial!=value){
                    _MiddleInitial=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="MiddleInitial");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _DriverSyncID;
        public string DriverSyncID
        {
            get { return _DriverSyncID; }
            set
            {
                if(_DriverSyncID!=value){
                    _DriverSyncID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="DriverSyncID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Terminal;
        public string Terminal
        {
            get { return _Terminal; }
            set
            {
                if(_Terminal!=value){
                    _Terminal=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Terminal");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<DRIVER, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the ScreenPositions table in the Dispatch Database.
    /// </summary>
    public partial class ScreenPosition: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<ScreenPosition> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<ScreenPosition>(new DispatchAR.DispatchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<ScreenPosition> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(ScreenPosition item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                ScreenPosition item=new ScreenPosition();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<ScreenPosition> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        DispatchAR.DispatchDB _db;
        public ScreenPosition(string connectionString, string providerName) {

            _db=new DispatchAR.DispatchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                ScreenPosition.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ScreenPosition>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public ScreenPosition(){
             _db=new DispatchAR.DispatchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public ScreenPosition(Expression<Func<ScreenPosition, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<ScreenPosition> GetRepo(string connectionString, string providerName){
            DispatchAR.DispatchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new DispatchAR.DispatchDB();
            }else{
                db=new DispatchAR.DispatchDB(connectionString, providerName);
            }
            IRepository<ScreenPosition> _repo;
            
            if(db.TestMode){
                ScreenPosition.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ScreenPosition>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<ScreenPosition> GetRepo(){
            return GetRepo("","");
        }
        
        public static ScreenPosition SingleOrDefault(Expression<Func<ScreenPosition, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            ScreenPosition single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static ScreenPosition SingleOrDefault(Expression<Func<ScreenPosition, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            ScreenPosition single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<ScreenPosition, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<ScreenPosition, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<ScreenPosition> Find(Expression<Func<ScreenPosition, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<ScreenPosition> Find(Expression<Func<ScreenPosition, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<ScreenPosition> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<ScreenPosition> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<ScreenPosition> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<ScreenPosition> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<ScreenPosition> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<ScreenPosition> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ScreenPositionID";
        }

        public object KeyValue()
        {
            return this.ScreenPositionID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.Route.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(ScreenPosition)){
                ScreenPosition compare=(ScreenPosition)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ScreenPositionID;
        }
        
        public string DescriptorValue()
        {
            return this.Route.ToString();
        }

        public string DescriptorColumn() {
            return "Route";
        }
        public static string GetKeyColumn()
        {
            return "ScreenPositionID";
        }        
        public static string GetDescriptorColumn()
        {
            return "Route";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ScreenPositionID;
        public int ScreenPositionID
        {
            get { return _ScreenPositionID; }
            set
            {
                if(_ScreenPositionID!=value){
                    _ScreenPositionID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ScreenPositionID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Route;
        public string Route
        {
            get { return _Route; }
            set
            {
                if(_Route!=value){
                    _Route=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Route");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _ScreenNumberInt;
        public int? ScreenNumberInt
        {
            get { return _ScreenNumberInt; }
            set
            {
                if(_ScreenNumberInt!=value){
                    _ScreenNumberInt=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ScreenNumberInt");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _WindowNameStr;
        public string WindowNameStr
        {
            get { return _WindowNameStr; }
            set
            {
                if(_WindowNameStr!=value){
                    _WindowNameStr=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WindowNameStr");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _LeftInt;
        public int? LeftInt
        {
            get { return _LeftInt; }
            set
            {
                if(_LeftInt!=value){
                    _LeftInt=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LeftInt");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _TopInt;
        public int? TopInt
        {
            get { return _TopInt; }
            set
            {
                if(_TopInt!=value){
                    _TopInt=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TopInt");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _WidthInt;
        public int? WidthInt
        {
            get { return _WidthInt; }
            set
            {
                if(_WidthInt!=value){
                    _WidthInt=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WidthInt");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _HeightInt;
        public int? HeightInt
        {
            get { return _HeightInt; }
            set
            {
                if(_HeightInt!=value){
                    _HeightInt=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeightInt");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<ScreenPosition, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Pickups table in the Dispatch Database.
    /// </summary>
    public partial class Pickup: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Pickup> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Pickup>(new DispatchAR.DispatchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Pickup> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Pickup item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Pickup item=new Pickup();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Pickup> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        DispatchAR.DispatchDB _db;
        public Pickup(string connectionString, string providerName) {

            _db=new DispatchAR.DispatchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Pickup.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Pickup>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Pickup(){
             _db=new DispatchAR.DispatchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Pickup(Expression<Func<Pickup, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Pickup> GetRepo(string connectionString, string providerName){
            DispatchAR.DispatchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new DispatchAR.DispatchDB();
            }else{
                db=new DispatchAR.DispatchDB(connectionString, providerName);
            }
            IRepository<Pickup> _repo;
            
            if(db.TestMode){
                Pickup.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Pickup>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Pickup> GetRepo(){
            return GetRepo("","");
        }
        
        public static Pickup SingleOrDefault(Expression<Func<Pickup, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Pickup single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Pickup SingleOrDefault(Expression<Func<Pickup, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Pickup single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Pickup, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Pickup, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Pickup> Find(Expression<Func<Pickup, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Pickup> Find(Expression<Func<Pickup, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Pickup> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Pickup> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Pickup> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Pickup> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Pickup> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Pickup> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.DefaultRouteID.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Pickup)){
                Pickup compare=(Pickup)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
            return this.DefaultRouteID.ToString();
        }

        public string DescriptorColumn() {
            return "DefaultRouteID";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "DefaultRouteID";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _DefaultRouteID;
        public string DefaultRouteID
        {
            get { return _DefaultRouteID; }
            set
            {
                if(_DefaultRouteID!=value){
                    _DefaultRouteID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="DefaultRouteID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _PickupDate;
        public DateTime? PickupDate
        {
            get { return _PickupDate; }
            set
            {
                if(_PickupDate!=value){
                    _PickupDate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PickupDate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CustomerID;
        public string CustomerID
        {
            get { return _CustomerID; }
            set
            {
                if(_CustomerID!=value){
                    _CustomerID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CustomerID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _DriverName;
        public string DriverName
        {
            get { return _DriverName; }
            set
            {
                if(_DriverName!=value){
                    _DriverName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="DriverName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _RouteName;
        public string RouteName
        {
            get { return _RouteName; }
            set
            {
                if(_RouteName!=value){
                    _RouteName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RouteName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CustomerName;
        public string CustomerName
        {
            get { return _CustomerName; }
            set
            {
                if(_CustomerName!=value){
                    _CustomerName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CustomerName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Comment;
        public string Comment
        {
            get { return _Comment; }
            set
            {
                if(_Comment!=value){
                    _Comment=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Comment");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _Monday;
        public bool? Monday
        {
            get { return _Monday; }
            set
            {
                if(_Monday!=value){
                    _Monday=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Monday");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _Tuesday;
        public bool? Tuesday
        {
            get { return _Tuesday; }
            set
            {
                if(_Tuesday!=value){
                    _Tuesday=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Tuesday");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _Wednesday;
        public bool? Wednesday
        {
            get { return _Wednesday; }
            set
            {
                if(_Wednesday!=value){
                    _Wednesday=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Wednesday");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _Thursday;
        public bool? Thursday
        {
            get { return _Thursday; }
            set
            {
                if(_Thursday!=value){
                    _Thursday=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Thursday");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _Friday;
        public bool? Friday
        {
            get { return _Friday; }
            set
            {
                if(_Friday!=value){
                    _Friday=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Friday");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _Dispatched;
        public bool? Dispatched
        {
            get { return _Dispatched; }
            set
            {
                if(_Dispatched!=value){
                    _Dispatched=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Dispatched");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _DispatchTime;
        public DateTime? DispatchTime
        {
            get { return _DispatchTime; }
            set
            {
                if(_DispatchTime!=value){
                    _DispatchTime=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="DispatchTime");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Notes;
        public string Notes
        {
            get { return _Notes; }
            set
            {
                if(_Notes!=value){
                    _Notes=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Notes");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _PickupSyncID;
        public string PickupSyncID
        {
            get { return _PickupSyncID; }
            set
            {
                if(_PickupSyncID!=value){
                    _PickupSyncID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PickupSyncID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Terminal;
        public string Terminal
        {
            get { return _Terminal; }
            set
            {
                if(_Terminal!=value){
                    _Terminal=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Terminal");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Pickup, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the CurrentDayRoutes table in the Dispatch Database.
    /// </summary>
    public partial class CurrentDayRoute: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<CurrentDayRoute> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<CurrentDayRoute>(new DispatchAR.DispatchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<CurrentDayRoute> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(CurrentDayRoute item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                CurrentDayRoute item=new CurrentDayRoute();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<CurrentDayRoute> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        DispatchAR.DispatchDB _db;
        public CurrentDayRoute(string connectionString, string providerName) {

            _db=new DispatchAR.DispatchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                CurrentDayRoute.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CurrentDayRoute>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public CurrentDayRoute(){
             _db=new DispatchAR.DispatchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public CurrentDayRoute(Expression<Func<CurrentDayRoute, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<CurrentDayRoute> GetRepo(string connectionString, string providerName){
            DispatchAR.DispatchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new DispatchAR.DispatchDB();
            }else{
                db=new DispatchAR.DispatchDB(connectionString, providerName);
            }
            IRepository<CurrentDayRoute> _repo;
            
            if(db.TestMode){
                CurrentDayRoute.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CurrentDayRoute>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<CurrentDayRoute> GetRepo(){
            return GetRepo("","");
        }
        
        public static CurrentDayRoute SingleOrDefault(Expression<Func<CurrentDayRoute, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            CurrentDayRoute single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static CurrentDayRoute SingleOrDefault(Expression<Func<CurrentDayRoute, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            CurrentDayRoute single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<CurrentDayRoute, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<CurrentDayRoute, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<CurrentDayRoute> Find(Expression<Func<CurrentDayRoute, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<CurrentDayRoute> Find(Expression<Func<CurrentDayRoute, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<CurrentDayRoute> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<CurrentDayRoute> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<CurrentDayRoute> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<CurrentDayRoute> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<CurrentDayRoute> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<CurrentDayRoute> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CurrentDayRouteID";
        }

        public object KeyValue()
        {
            return this.CurrentDayRouteID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CDRRouteID.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(CurrentDayRoute)){
                CurrentDayRoute compare=(CurrentDayRoute)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.CurrentDayRouteID;
        }
        
        public string DescriptorValue()
        {
            return this.CDRRouteID.ToString();
        }

        public string DescriptorColumn() {
            return "CDRRouteID";
        }
        public static string GetKeyColumn()
        {
            return "CurrentDayRouteID";
        }        
        public static string GetDescriptorColumn()
        {
            return "CDRRouteID";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _CurrentDayRouteID;
        public int CurrentDayRouteID
        {
            get { return _CurrentDayRouteID; }
            set
            {
                if(_CurrentDayRouteID!=value){
                    _CurrentDayRouteID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CurrentDayRouteID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDRRouteID;
        public string CDRRouteID
        {
            get { return _CDRRouteID; }
            set
            {
                if(_CDRRouteID!=value){
                    _CDRRouteID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDRRouteID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDRRouteName;
        public string CDRRouteName
        {
            get { return _CDRRouteName; }
            set
            {
                if(_CDRRouteName!=value){
                    _CDRRouteName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDRRouteName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDRDefaultDriverID;
        public string CDRDefaultDriverID
        {
            get { return _CDRDefaultDriverID; }
            set
            {
                if(_CDRDefaultDriverID!=value){
                    _CDRDefaultDriverID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDRDefaultDriverID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDRDriverLastName;
        public string CDRDriverLastName
        {
            get { return _CDRDriverLastName; }
            set
            {
                if(_CDRDriverLastName!=value){
                    _CDRDriverLastName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDRDriverLastName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDRDriverMessage;
        public string CDRDriverMessage
        {
            get { return _CDRDriverMessage; }
            set
            {
                if(_CDRDriverMessage!=value){
                    _CDRDriverMessage=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDRDriverMessage");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CDRStation;
        public string CDRStation
        {
            get { return _CDRStation; }
            set
            {
                if(_CDRStation!=value){
                    _CDRStation=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CDRStation");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Terminal;
        public string Terminal
        {
            get { return _Terminal; }
            set
            {
                if(_Terminal!=value){
                    _Terminal=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Terminal");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<CurrentDayRoute, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Routes table in the Dispatch Database.
    /// </summary>
    public partial class Route: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Route> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Route>(new DispatchAR.DispatchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Route> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Route item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Route item=new Route();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Route> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        DispatchAR.DispatchDB _db;
        public Route(string connectionString, string providerName) {

            _db=new DispatchAR.DispatchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Route.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Route>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Route(){
             _db=new DispatchAR.DispatchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Route(Expression<Func<Route, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Route> GetRepo(string connectionString, string providerName){
            DispatchAR.DispatchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new DispatchAR.DispatchDB();
            }else{
                db=new DispatchAR.DispatchDB(connectionString, providerName);
            }
            IRepository<Route> _repo;
            
            if(db.TestMode){
                Route.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Route>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Route> GetRepo(){
            return GetRepo("","");
        }
        
        public static Route SingleOrDefault(Expression<Func<Route, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Route single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Route SingleOrDefault(Expression<Func<Route, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Route single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Route, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Route, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Route> Find(Expression<Func<Route, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Route> Find(Expression<Func<Route, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Route> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Route> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Route> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Route> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Route> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Route> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "Route2TableID";
        }

        public object KeyValue()
        {
            return this.Route2TableID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.RouteID.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Route)){
                Route compare=(Route)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.Route2TableID;
        }
        
        public string DescriptorValue()
        {
            return this.RouteID.ToString();
        }

        public string DescriptorColumn() {
            return "RouteID";
        }
        public static string GetKeyColumn()
        {
            return "Route2TableID";
        }        
        public static string GetDescriptorColumn()
        {
            return "RouteID";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _Route2TableID;
        public int Route2TableID
        {
            get { return _Route2TableID; }
            set
            {
                if(_Route2TableID!=value){
                    _Route2TableID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Route2TableID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _RouteID;
        public string RouteID
        {
            get { return _RouteID; }
            set
            {
                if(_RouteID!=value){
                    _RouteID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RouteID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _RouteName;
        public string RouteName
        {
            get { return _RouteName; }
            set
            {
                if(_RouteName!=value){
                    _RouteName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RouteName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _DefaultDriverID;
        public string DefaultDriverID
        {
            get { return _DefaultDriverID; }
            set
            {
                if(_DefaultDriverID!=value){
                    _DefaultDriverID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="DefaultDriverID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _DriverMessage;
        public string DriverMessage
        {
            get { return _DriverMessage; }
            set
            {
                if(_DriverMessage!=value){
                    _DriverMessage=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="DriverMessage");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        short? _Screen;
        public short? Screen
        {
            get { return _Screen; }
            set
            {
                if(_Screen!=value){
                    _Screen=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Screen");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _RouteSyncID;
        public string RouteSyncID
        {
            get { return _RouteSyncID; }
            set
            {
                if(_RouteSyncID!=value){
                    _RouteSyncID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RouteSyncID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _RouteCreatedBy;
        public string RouteCreatedBy
        {
            get { return _RouteCreatedBy; }
            set
            {
                if(_RouteCreatedBy!=value){
                    _RouteCreatedBy=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RouteCreatedBy");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _RouteCreatedTime;
        public DateTime? RouteCreatedTime
        {
            get { return _RouteCreatedTime; }
            set
            {
                if(_RouteCreatedTime!=value){
                    _RouteCreatedTime=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RouteCreatedTime");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _RouteEditedBy;
        public string RouteEditedBy
        {
            get { return _RouteEditedBy; }
            set
            {
                if(_RouteEditedBy!=value){
                    _RouteEditedBy=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RouteEditedBy");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _RouteEditedTime;
        public DateTime? RouteEditedTime
        {
            get { return _RouteEditedTime; }
            set
            {
                if(_RouteEditedTime!=value){
                    _RouteEditedTime=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RouteEditedTime");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _RouteSent;
        public bool? RouteSent
        {
            get { return _RouteSent; }
            set
            {
                if(_RouteSent!=value){
                    _RouteSent=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RouteSent");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _RouteSentTime;
        public DateTime? RouteSentTime
        {
            get { return _RouteSentTime; }
            set
            {
                if(_RouteSentTime!=value){
                    _RouteSentTime=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RouteSentTime");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _RouteSendConfirmed;
        public bool? RouteSendConfirmed
        {
            get { return _RouteSendConfirmed; }
            set
            {
                if(_RouteSendConfirmed!=value){
                    _RouteSendConfirmed=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RouteSendConfirmed");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _RouteReceivedTime;
        public DateTime? RouteReceivedTime
        {
            get { return _RouteReceivedTime; }
            set
            {
                if(_RouteReceivedTime!=value){
                    _RouteReceivedTime=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RouteReceivedTime");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Terminal;
        public string Terminal
        {
            get { return _Terminal; }
            set
            {
                if(_Terminal!=value){
                    _Terminal=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Terminal");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Route, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
}
