


using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace DispatchAR {
	
        /// <summary>
        /// Table: CUSTOMERS
        /// Primary Key: CustomerID
        /// </summary>

        public class CUSTOMERSTable: DatabaseTable {
            
            public CUSTOMERSTable(IDataProvider provider):base("CUSTOMERS",provider){
                ClassName = "CUSTOMER";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CustomerID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("CustomerName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("Address1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("Address2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("State", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("Phone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 13
                });

                Columns.Add(new DatabaseColumn("Contact", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("ClosingTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 5
                });

                Columns.Add(new DatabaseColumn("Comment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("DefaultRouteID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("CustomerSyncID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Terminal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("InfoString", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });
                    
                
                
            }
            
            public IColumn CustomerID{
                get{
                    return this.GetColumn("CustomerID");
                }
            }
				
   			public static string CustomerIDColumn{
			      get{
        			return "CustomerID";
      			}
		    }
            
            public IColumn CustomerName{
                get{
                    return this.GetColumn("CustomerName");
                }
            }
				
   			public static string CustomerNameColumn{
			      get{
        			return "CustomerName";
      			}
		    }
            
            public IColumn Address1{
                get{
                    return this.GetColumn("Address1");
                }
            }
				
   			public static string Address1Column{
			      get{
        			return "Address1";
      			}
		    }
            
            public IColumn Address2{
                get{
                    return this.GetColumn("Address2");
                }
            }
				
   			public static string Address2Column{
			      get{
        			return "Address2";
      			}
		    }
            
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
            
            public IColumn State{
                get{
                    return this.GetColumn("State");
                }
            }
				
   			public static string StateColumn{
			      get{
        			return "State";
      			}
		    }
            
            public IColumn Phone{
                get{
                    return this.GetColumn("Phone");
                }
            }
				
   			public static string PhoneColumn{
			      get{
        			return "Phone";
      			}
		    }
            
            public IColumn Contact{
                get{
                    return this.GetColumn("Contact");
                }
            }
				
   			public static string ContactColumn{
			      get{
        			return "Contact";
      			}
		    }
            
            public IColumn ClosingTime{
                get{
                    return this.GetColumn("ClosingTime");
                }
            }
				
   			public static string ClosingTimeColumn{
			      get{
        			return "ClosingTime";
      			}
		    }
            
            public IColumn Comment{
                get{
                    return this.GetColumn("Comment");
                }
            }
				
   			public static string CommentColumn{
			      get{
        			return "Comment";
      			}
		    }
            
            public IColumn DefaultRouteID{
                get{
                    return this.GetColumn("DefaultRouteID");
                }
            }
				
   			public static string DefaultRouteIDColumn{
			      get{
        			return "DefaultRouteID";
      			}
		    }
            
            public IColumn CustomerSyncID{
                get{
                    return this.GetColumn("CustomerSyncID");
                }
            }
				
   			public static string CustomerSyncIDColumn{
			      get{
        			return "CustomerSyncID";
      			}
		    }
            
            public IColumn Terminal{
                get{
                    return this.GetColumn("Terminal");
                }
            }
				
   			public static string TerminalColumn{
			      get{
        			return "Terminal";
      			}
		    }
            
            public IColumn InfoString{
                get{
                    return this.GetColumn("InfoString");
                }
            }
				
   			public static string InfoStringColumn{
			      get{
        			return "InfoString";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Postings
        /// Primary Key: PostingID
        /// </summary>

        public class PostingsTable: DatabaseTable {
            
            public PostingsTable(IDataProvider provider):base("Postings",provider){
                ClassName = "Posting";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PostingID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DataType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("key", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DefaultRouteId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("PreviousRouteID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("NumberOfPendingUpdates", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Originator", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("IsDragNDrop", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn PostingID{
                get{
                    return this.GetColumn("PostingID");
                }
            }
				
   			public static string PostingIDColumn{
			      get{
        			return "PostingID";
      			}
		    }
            
            public IColumn DataType{
                get{
                    return this.GetColumn("DataType");
                }
            }
				
   			public static string DataTypeColumn{
			      get{
        			return "DataType";
      			}
		    }
            
            public IColumn key{
                get{
                    return this.GetColumn("key");
                }
            }
				
   			public static string keyColumn{
			      get{
        			return "key";
      			}
		    }
            
            public IColumn DefaultRouteId{
                get{
                    return this.GetColumn("DefaultRouteId");
                }
            }
				
   			public static string DefaultRouteIdColumn{
			      get{
        			return "DefaultRouteId";
      			}
		    }
            
            public IColumn PreviousRouteID{
                get{
                    return this.GetColumn("PreviousRouteID");
                }
            }
				
   			public static string PreviousRouteIDColumn{
			      get{
        			return "PreviousRouteID";
      			}
		    }
            
            public IColumn NumberOfPendingUpdates{
                get{
                    return this.GetColumn("NumberOfPendingUpdates");
                }
            }
				
   			public static string NumberOfPendingUpdatesColumn{
			      get{
        			return "NumberOfPendingUpdates";
      			}
		    }
            
            public IColumn Originator{
                get{
                    return this.GetColumn("Originator");
                }
            }
				
   			public static string OriginatorColumn{
			      get{
        			return "Originator";
      			}
		    }
            
            public IColumn IsDragNDrop{
                get{
                    return this.GetColumn("IsDragNDrop");
                }
            }
				
   			public static string IsDragNDropColumn{
			      get{
        			return "IsDragNDrop";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CurrentDayPickups
        /// Primary Key: CurrentDayPickupID
        /// </summary>

        public class CurrentDayPickupsTable: DatabaseTable {
            
            public CurrentDayPickupsTable(IDataProvider provider):base("CurrentDayPickups",provider){
                ClassName = "CurrentDayPickup";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CurrentDayPickupID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CDPDefaultRouteID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("CDPPreviousRouteID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("CDPPickupDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CDPCustomerID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 5
                });

                Columns.Add(new DatabaseColumn("CDPDriverName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("CDPDriverMessage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("CDPRouteName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("CDPCustomerName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("CDPComment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("CDPDispatched", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CDPDispatchTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CDPNotes", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("CDPStation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CDPDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Terminal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("CDPEditedBy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });
                    
                
                
            }
            
            public IColumn CurrentDayPickupID{
                get{
                    return this.GetColumn("CurrentDayPickupID");
                }
            }
				
   			public static string CurrentDayPickupIDColumn{
			      get{
        			return "CurrentDayPickupID";
      			}
		    }
            
            public IColumn CDPDefaultRouteID{
                get{
                    return this.GetColumn("CDPDefaultRouteID");
                }
            }
				
   			public static string CDPDefaultRouteIDColumn{
			      get{
        			return "CDPDefaultRouteID";
      			}
		    }
            
            public IColumn CDPPreviousRouteID{
                get{
                    return this.GetColumn("CDPPreviousRouteID");
                }
            }
				
   			public static string CDPPreviousRouteIDColumn{
			      get{
        			return "CDPPreviousRouteID";
      			}
		    }
            
            public IColumn CDPPickupDate{
                get{
                    return this.GetColumn("CDPPickupDate");
                }
            }
				
   			public static string CDPPickupDateColumn{
			      get{
        			return "CDPPickupDate";
      			}
		    }
            
            public IColumn CDPCustomerID{
                get{
                    return this.GetColumn("CDPCustomerID");
                }
            }
				
   			public static string CDPCustomerIDColumn{
			      get{
        			return "CDPCustomerID";
      			}
		    }
            
            public IColumn CDPDriverName{
                get{
                    return this.GetColumn("CDPDriverName");
                }
            }
				
   			public static string CDPDriverNameColumn{
			      get{
        			return "CDPDriverName";
      			}
		    }
            
            public IColumn CDPDriverMessage{
                get{
                    return this.GetColumn("CDPDriverMessage");
                }
            }
				
   			public static string CDPDriverMessageColumn{
			      get{
        			return "CDPDriverMessage";
      			}
		    }
            
            public IColumn CDPRouteName{
                get{
                    return this.GetColumn("CDPRouteName");
                }
            }
				
   			public static string CDPRouteNameColumn{
			      get{
        			return "CDPRouteName";
      			}
		    }
            
            public IColumn CDPCustomerName{
                get{
                    return this.GetColumn("CDPCustomerName");
                }
            }
				
   			public static string CDPCustomerNameColumn{
			      get{
        			return "CDPCustomerName";
      			}
		    }
            
            public IColumn CDPComment{
                get{
                    return this.GetColumn("CDPComment");
                }
            }
				
   			public static string CDPCommentColumn{
			      get{
        			return "CDPComment";
      			}
		    }
            
            public IColumn CDPDispatched{
                get{
                    return this.GetColumn("CDPDispatched");
                }
            }
				
   			public static string CDPDispatchedColumn{
			      get{
        			return "CDPDispatched";
      			}
		    }
            
            public IColumn CDPDispatchTime{
                get{
                    return this.GetColumn("CDPDispatchTime");
                }
            }
				
   			public static string CDPDispatchTimeColumn{
			      get{
        			return "CDPDispatchTime";
      			}
		    }
            
            public IColumn CDPNotes{
                get{
                    return this.GetColumn("CDPNotes");
                }
            }
				
   			public static string CDPNotesColumn{
			      get{
        			return "CDPNotes";
      			}
		    }
            
            public IColumn CDPStation{
                get{
                    return this.GetColumn("CDPStation");
                }
            }
				
   			public static string CDPStationColumn{
			      get{
        			return "CDPStation";
      			}
		    }
            
            public IColumn CDPDeleted{
                get{
                    return this.GetColumn("CDPDeleted");
                }
            }
				
   			public static string CDPDeletedColumn{
			      get{
        			return "CDPDeleted";
      			}
		    }
            
            public IColumn Terminal{
                get{
                    return this.GetColumn("Terminal");
                }
            }
				
   			public static string TerminalColumn{
			      get{
        			return "Terminal";
      			}
		    }
            
            public IColumn CDPEditedBy{
                get{
                    return this.GetColumn("CDPEditedBy");
                }
            }
				
   			public static string CDPEditedByColumn{
			      get{
        			return "CDPEditedBy";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: DRIVERS
        /// Primary Key: DriverTableID
        /// </summary>

        public class DRIVERSTable: DatabaseTable {
            
            public DRIVERSTable(IDataProvider provider):base("DRIVERS",provider){
                ClassName = "DRIVER";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DriverTableID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DriverID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 4
                });

                Columns.Add(new DatabaseColumn("LastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("FirstName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("MiddleInitial", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1
                });

                Columns.Add(new DatabaseColumn("DriverSyncID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Terminal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });
                    
                
                
            }
            
            public IColumn DriverTableID{
                get{
                    return this.GetColumn("DriverTableID");
                }
            }
				
   			public static string DriverTableIDColumn{
			      get{
        			return "DriverTableID";
      			}
		    }
            
            public IColumn DriverID{
                get{
                    return this.GetColumn("DriverID");
                }
            }
				
   			public static string DriverIDColumn{
			      get{
        			return "DriverID";
      			}
		    }
            
            public IColumn LastName{
                get{
                    return this.GetColumn("LastName");
                }
            }
				
   			public static string LastNameColumn{
			      get{
        			return "LastName";
      			}
		    }
            
            public IColumn FirstName{
                get{
                    return this.GetColumn("FirstName");
                }
            }
				
   			public static string FirstNameColumn{
			      get{
        			return "FirstName";
      			}
		    }
            
            public IColumn MiddleInitial{
                get{
                    return this.GetColumn("MiddleInitial");
                }
            }
				
   			public static string MiddleInitialColumn{
			      get{
        			return "MiddleInitial";
      			}
		    }
            
            public IColumn DriverSyncID{
                get{
                    return this.GetColumn("DriverSyncID");
                }
            }
				
   			public static string DriverSyncIDColumn{
			      get{
        			return "DriverSyncID";
      			}
		    }
            
            public IColumn Terminal{
                get{
                    return this.GetColumn("Terminal");
                }
            }
				
   			public static string TerminalColumn{
			      get{
        			return "Terminal";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ScreenPositions
        /// Primary Key: ScreenPositionID
        /// </summary>

        public class ScreenPositionsTable: DatabaseTable {
            
            public ScreenPositionsTable(IDataProvider provider):base("ScreenPositions",provider){
                ClassName = "ScreenPosition";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ScreenPositionID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Route", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ScreenNumberInt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WindowNameStr", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("LeftInt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TopInt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WidthInt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeightInt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ScreenPositionID{
                get{
                    return this.GetColumn("ScreenPositionID");
                }
            }
				
   			public static string ScreenPositionIDColumn{
			      get{
        			return "ScreenPositionID";
      			}
		    }
            
            public IColumn Route{
                get{
                    return this.GetColumn("Route");
                }
            }
				
   			public static string RouteColumn{
			      get{
        			return "Route";
      			}
		    }
            
            public IColumn ScreenNumberInt{
                get{
                    return this.GetColumn("ScreenNumberInt");
                }
            }
				
   			public static string ScreenNumberIntColumn{
			      get{
        			return "ScreenNumberInt";
      			}
		    }
            
            public IColumn WindowNameStr{
                get{
                    return this.GetColumn("WindowNameStr");
                }
            }
				
   			public static string WindowNameStrColumn{
			      get{
        			return "WindowNameStr";
      			}
		    }
            
            public IColumn LeftInt{
                get{
                    return this.GetColumn("LeftInt");
                }
            }
				
   			public static string LeftIntColumn{
			      get{
        			return "LeftInt";
      			}
		    }
            
            public IColumn TopInt{
                get{
                    return this.GetColumn("TopInt");
                }
            }
				
   			public static string TopIntColumn{
			      get{
        			return "TopInt";
      			}
		    }
            
            public IColumn WidthInt{
                get{
                    return this.GetColumn("WidthInt");
                }
            }
				
   			public static string WidthIntColumn{
			      get{
        			return "WidthInt";
      			}
		    }
            
            public IColumn HeightInt{
                get{
                    return this.GetColumn("HeightInt");
                }
            }
				
   			public static string HeightIntColumn{
			      get{
        			return "HeightInt";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Pickups
        /// Primary Key: ID
        /// </summary>

        public class PickupsTable: DatabaseTable {
            
            public PickupsTable(IDataProvider provider):base("Pickups",provider){
                ClassName = "Pickup";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DefaultRouteID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("PickupDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CustomerID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 5
                });

                Columns.Add(new DatabaseColumn("DriverName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("RouteName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("CustomerName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("Comment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("Monday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Tuesday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Wednesday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Thursday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Friday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Dispatched", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DispatchTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Notes", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("PickupSyncID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Terminal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });
                    
                
                
            }
            
            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn DefaultRouteID{
                get{
                    return this.GetColumn("DefaultRouteID");
                }
            }
				
   			public static string DefaultRouteIDColumn{
			      get{
        			return "DefaultRouteID";
      			}
		    }
            
            public IColumn PickupDate{
                get{
                    return this.GetColumn("PickupDate");
                }
            }
				
   			public static string PickupDateColumn{
			      get{
        			return "PickupDate";
      			}
		    }
            
            public IColumn CustomerID{
                get{
                    return this.GetColumn("CustomerID");
                }
            }
				
   			public static string CustomerIDColumn{
			      get{
        			return "CustomerID";
      			}
		    }
            
            public IColumn DriverName{
                get{
                    return this.GetColumn("DriverName");
                }
            }
				
   			public static string DriverNameColumn{
			      get{
        			return "DriverName";
      			}
		    }
            
            public IColumn RouteName{
                get{
                    return this.GetColumn("RouteName");
                }
            }
				
   			public static string RouteNameColumn{
			      get{
        			return "RouteName";
      			}
		    }
            
            public IColumn CustomerName{
                get{
                    return this.GetColumn("CustomerName");
                }
            }
				
   			public static string CustomerNameColumn{
			      get{
        			return "CustomerName";
      			}
		    }
            
            public IColumn Comment{
                get{
                    return this.GetColumn("Comment");
                }
            }
				
   			public static string CommentColumn{
			      get{
        			return "Comment";
      			}
		    }
            
            public IColumn Monday{
                get{
                    return this.GetColumn("Monday");
                }
            }
				
   			public static string MondayColumn{
			      get{
        			return "Monday";
      			}
		    }
            
            public IColumn Tuesday{
                get{
                    return this.GetColumn("Tuesday");
                }
            }
				
   			public static string TuesdayColumn{
			      get{
        			return "Tuesday";
      			}
		    }
            
            public IColumn Wednesday{
                get{
                    return this.GetColumn("Wednesday");
                }
            }
				
   			public static string WednesdayColumn{
			      get{
        			return "Wednesday";
      			}
		    }
            
            public IColumn Thursday{
                get{
                    return this.GetColumn("Thursday");
                }
            }
				
   			public static string ThursdayColumn{
			      get{
        			return "Thursday";
      			}
		    }
            
            public IColumn Friday{
                get{
                    return this.GetColumn("Friday");
                }
            }
				
   			public static string FridayColumn{
			      get{
        			return "Friday";
      			}
		    }
            
            public IColumn Dispatched{
                get{
                    return this.GetColumn("Dispatched");
                }
            }
				
   			public static string DispatchedColumn{
			      get{
        			return "Dispatched";
      			}
		    }
            
            public IColumn DispatchTime{
                get{
                    return this.GetColumn("DispatchTime");
                }
            }
				
   			public static string DispatchTimeColumn{
			      get{
        			return "DispatchTime";
      			}
		    }
            
            public IColumn Notes{
                get{
                    return this.GetColumn("Notes");
                }
            }
				
   			public static string NotesColumn{
			      get{
        			return "Notes";
      			}
		    }
            
            public IColumn PickupSyncID{
                get{
                    return this.GetColumn("PickupSyncID");
                }
            }
				
   			public static string PickupSyncIDColumn{
			      get{
        			return "PickupSyncID";
      			}
		    }
            
            public IColumn Terminal{
                get{
                    return this.GetColumn("Terminal");
                }
            }
				
   			public static string TerminalColumn{
			      get{
        			return "Terminal";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CurrentDayRoutes
        /// Primary Key: CurrentDayRouteID
        /// </summary>

        public class CurrentDayRoutesTable: DatabaseTable {
            
            public CurrentDayRoutesTable(IDataProvider provider):base("CurrentDayRoutes",provider){
                ClassName = "CurrentDayRoute";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CurrentDayRouteID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CDRRouteID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("CDRRouteName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("CDRDefaultDriverID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 4
                });

                Columns.Add(new DatabaseColumn("CDRDriverLastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("CDRDriverMessage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("CDRStation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Terminal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });
                    
                
                
            }
            
            public IColumn CurrentDayRouteID{
                get{
                    return this.GetColumn("CurrentDayRouteID");
                }
            }
				
   			public static string CurrentDayRouteIDColumn{
			      get{
        			return "CurrentDayRouteID";
      			}
		    }
            
            public IColumn CDRRouteID{
                get{
                    return this.GetColumn("CDRRouteID");
                }
            }
				
   			public static string CDRRouteIDColumn{
			      get{
        			return "CDRRouteID";
      			}
		    }
            
            public IColumn CDRRouteName{
                get{
                    return this.GetColumn("CDRRouteName");
                }
            }
				
   			public static string CDRRouteNameColumn{
			      get{
        			return "CDRRouteName";
      			}
		    }
            
            public IColumn CDRDefaultDriverID{
                get{
                    return this.GetColumn("CDRDefaultDriverID");
                }
            }
				
   			public static string CDRDefaultDriverIDColumn{
			      get{
        			return "CDRDefaultDriverID";
      			}
		    }
            
            public IColumn CDRDriverLastName{
                get{
                    return this.GetColumn("CDRDriverLastName");
                }
            }
				
   			public static string CDRDriverLastNameColumn{
			      get{
        			return "CDRDriverLastName";
      			}
		    }
            
            public IColumn CDRDriverMessage{
                get{
                    return this.GetColumn("CDRDriverMessage");
                }
            }
				
   			public static string CDRDriverMessageColumn{
			      get{
        			return "CDRDriverMessage";
      			}
		    }
            
            public IColumn CDRStation{
                get{
                    return this.GetColumn("CDRStation");
                }
            }
				
   			public static string CDRStationColumn{
			      get{
        			return "CDRStation";
      			}
		    }
            
            public IColumn Terminal{
                get{
                    return this.GetColumn("Terminal");
                }
            }
				
   			public static string TerminalColumn{
			      get{
        			return "Terminal";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Routes
        /// Primary Key: Route2TableID
        /// </summary>

        public class RoutesTable: DatabaseTable {
            
            public RoutesTable(IDataProvider provider):base("Routes",provider){
                ClassName = "Route";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Route2TableID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RouteID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("RouteName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("DefaultDriverID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 4
                });

                Columns.Add(new DatabaseColumn("DriverMessage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Screen", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RouteSyncID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("RouteCreatedBy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("RouteCreatedTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RouteEditedBy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("RouteEditedTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RouteSent", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RouteSentTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RouteSendConfirmed", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RouteReceivedTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Terminal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });
                    
                
                
            }
            
            public IColumn Route2TableID{
                get{
                    return this.GetColumn("Route2TableID");
                }
            }
				
   			public static string Route2TableIDColumn{
			      get{
        			return "Route2TableID";
      			}
		    }
            
            public IColumn RouteID{
                get{
                    return this.GetColumn("RouteID");
                }
            }
				
   			public static string RouteIDColumn{
			      get{
        			return "RouteID";
      			}
		    }
            
            public IColumn RouteName{
                get{
                    return this.GetColumn("RouteName");
                }
            }
				
   			public static string RouteNameColumn{
			      get{
        			return "RouteName";
      			}
		    }
            
            public IColumn DefaultDriverID{
                get{
                    return this.GetColumn("DefaultDriverID");
                }
            }
				
   			public static string DefaultDriverIDColumn{
			      get{
        			return "DefaultDriverID";
      			}
		    }
            
            public IColumn DriverMessage{
                get{
                    return this.GetColumn("DriverMessage");
                }
            }
				
   			public static string DriverMessageColumn{
			      get{
        			return "DriverMessage";
      			}
		    }
            
            public IColumn Screen{
                get{
                    return this.GetColumn("Screen");
                }
            }
				
   			public static string ScreenColumn{
			      get{
        			return "Screen";
      			}
		    }
            
            public IColumn RouteSyncID{
                get{
                    return this.GetColumn("RouteSyncID");
                }
            }
				
   			public static string RouteSyncIDColumn{
			      get{
        			return "RouteSyncID";
      			}
		    }
            
            public IColumn RouteCreatedBy{
                get{
                    return this.GetColumn("RouteCreatedBy");
                }
            }
				
   			public static string RouteCreatedByColumn{
			      get{
        			return "RouteCreatedBy";
      			}
		    }
            
            public IColumn RouteCreatedTime{
                get{
                    return this.GetColumn("RouteCreatedTime");
                }
            }
				
   			public static string RouteCreatedTimeColumn{
			      get{
        			return "RouteCreatedTime";
      			}
		    }
            
            public IColumn RouteEditedBy{
                get{
                    return this.GetColumn("RouteEditedBy");
                }
            }
				
   			public static string RouteEditedByColumn{
			      get{
        			return "RouteEditedBy";
      			}
		    }
            
            public IColumn RouteEditedTime{
                get{
                    return this.GetColumn("RouteEditedTime");
                }
            }
				
   			public static string RouteEditedTimeColumn{
			      get{
        			return "RouteEditedTime";
      			}
		    }
            
            public IColumn RouteSent{
                get{
                    return this.GetColumn("RouteSent");
                }
            }
				
   			public static string RouteSentColumn{
			      get{
        			return "RouteSent";
      			}
		    }
            
            public IColumn RouteSentTime{
                get{
                    return this.GetColumn("RouteSentTime");
                }
            }
				
   			public static string RouteSentTimeColumn{
			      get{
        			return "RouteSentTime";
      			}
		    }
            
            public IColumn RouteSendConfirmed{
                get{
                    return this.GetColumn("RouteSendConfirmed");
                }
            }
				
   			public static string RouteSendConfirmedColumn{
			      get{
        			return "RouteSendConfirmed";
      			}
		    }
            
            public IColumn RouteReceivedTime{
                get{
                    return this.GetColumn("RouteReceivedTime");
                }
            }
				
   			public static string RouteReceivedTimeColumn{
			      get{
        			return "RouteReceivedTime";
      			}
		    }
            
            public IColumn Terminal{
                get{
                    return this.GetColumn("Terminal");
                }
            }
				
   			public static string TerminalColumn{
			      get{
        			return "Terminal";
      			}
		    }
            
                    
        }
        
}