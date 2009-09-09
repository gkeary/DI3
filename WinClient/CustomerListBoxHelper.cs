using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RossData;
using System.Collections;

namespace Dispatch3
{
    public class CustomerListBoxHelper
    {

        private static VCustomerListCollection mCustomerListCollection = new VCustomerListCollection();
        private static CustomerCollection mCustomerCollection = new CustomerCollection();
        private static PickupCollection mPickupCollection = new PickupCollection();
        private static ROUTE2Collection mRoute2Collection = new ROUTE2Collection();
        private static Hashtable PickupHash = new Hashtable();
        private static Hashtable CustListHash = new Hashtable();
        private static Hashtable CustomerHash = new Hashtable();
        private static Hashtable Route2Hash = new Hashtable();

        public static string GetCustomerName(string custID)
        {
            //Dim pp As Pickup = PickupHash.Item("NEWEL")
            //Dim pptrue As Boolean = PickupHash.Contains("NEWEL")
            //Dim foo As String = PickupHash.Item("NEWEL").CustomerName

            if (PickupHash.Contains(custID))
            {
            // TODO:  replace w/ LINQ expression?
                //return PickupHash.Item(custID).CustomerName;
            }
            else
            {
                return "";
            }
        }

        public static string GetRouteID(string custID)
        {
            //Dim pp As Pickup = PickupHash.Item("NEWEL")
            //Dim pptrue As Boolean = PickupHash.Contains("NEWEL")
            //Dim foo As String = PickupHash.Item("NEWEL").CustomerName

            if (CustListHash.Contains(custID))
            {
            // TODO:  replace w/ LINQ expression?
            //    return CustListHash.Item(custID).DefaultRouteID;
            }
            else
            {
                return "";
            }
        }
        public static string GetRoute2RouteName(string routeID)
        {
            string retValue = "";

            if (Route2Hash.Count > 0)
            {
                foreach (ROUTE2 r2 in Route2Hash.Values)
                {
                    if (r2.RouteID == routeID)
                    {
                        retValue = r2.RouteName;
                    }
                }
            }
            else
            {
            }
            return retValue;
        }
        public static string GetRoute2DefaultDriverID(string routeID)
        {
            string retvalue = "";
            if (Route2Hash.Count > 0)
            {
                foreach (ROUTE2 r2 in Route2Hash.Values)
                {
                    if (r2.RouteID == routeID)
                    {
                        retvalue = r2.DefaultDriverID;
                    }
                }
            }
            else
            {
            }
            return retvalue;
        }


        //Public Shared Function getRoute2TableID(ByVal RouteID As String) As Integer
        //    For Each r2 As ROUTE2 In Route2Hash.Keys
        //        If r2.RouteID = RouteID Then
        //            Return r2.Route2TableID
        //        End If
        //    Next
        //End Function
        public static Hashtable PopulatePickupHash()
        {

            foreach (Pickup pickup in mPickupCollection.Load())
            {
                // adds to the hash if not yet there
                // changes it if it IS already there
                // i.e. this is an "UPSERT"
                if ((pickup.PickupDate.HasValue))
                {
                    if (pickup.PickupDate > DateTime.Today)
                    {
                        continue;
                    }
                    else
                    {
                        if (PickupHash.Contains(pickup.CustomerID))
                        {
            // TODO:  replace w/ LINQ expression?
                            //Update it -- Last ONE wins
            //                PickupHash.Item(pickup.CustomerID) = pickup;
                        }
                        else
                        {
                            //Create it
                            PickupHash.Add(pickup.CustomerID, pickup);
                        }
                    }
                }
            }
            return PickupHash;
        }
        public static Hashtable PopulateCustomerHash()
        {

            foreach (Customer customer in mCustomerCollection.Load())
            {
                // adds to the hash if not yet there
                // changes it if it IS already there
                // i.e. this is an "UPSERT"
                if (CustomerHash.Contains(customer.CustomerID))
                {
            // TODO:  replace w/ LINQ expression?
                    //Update it -- Last ONE wins
            //        CustomerHash.Item(customer.CustomerID) = customer;
                }
                else
                {
                    //Create it
                    CustomerHash.Add(customer.CustomerID, customer);
                }
            }

            //' I used the following text as an outline in developing this...
            // populate a hash with fixed_up(CustomerName) as key and CustomerID as value
            //     fixed_up defined as:  Uppercase(replace( spaces, periods, ampersands, commas, other? with NOTHING))
            //         so:  A.B.C Corp  --> ABCCorp
            //         key_down event should:
            //                take the Uppercase of <the input keystroke> 
            //            and
            //                add it to the <search string>
            // then you can seek on <search string> within the hash such that:
            //   <searchstring> = key
            // and set txtCustomerList.selected <there>
            // then you can populate the form view based on the selected record.
            //  this should work
            //  but first clean this up:
            //    a: populate one collection and use it in all the subroutines
            //    b: create and use a query object for seeking
            //           use: vCustomerlist.FetchByID(CustomerTableID) 
            //    c: examine and fixup the pickup table rows. 
            //           how many are there?
            //             per CustomerID?   
            //           how many should there be?
            //       here are the business rules:
            //           for a given customer id 
            //              if date is blank --- create a row with at least one monday tuesday... checked
            //              if date is not blank
            //              create a row for that date 
            //                   this row should have monday, tuesday, .... all UNCHECKED
            //              if date < today 
            //                  create a default row (with all 5 days checked
            //                   delete the row

            return CustomerHash;
        }

        public static Hashtable PopulateCustListHash()
        {

            foreach (VCustomerList vcustomerlist in mCustomerListCollection.Load())
            {
                // adds to the hash if not yet there
                // changes it if it IS already there
                // i.e. this is an "UPSERT"
                if (CustListHash.Contains(vcustomerlist.CustomerID))
                {
            // TODO:  replace w/ LINQ expression?
                    //Update it -- Last ONE wins
            //        CustListHash.Item(vcustomerlist.CustomerID) = vcustomerlist;
                }
                else
                {
                    //Create it
                    CustListHash.Add(vcustomerlist.CustomerID, vcustomerlist);
                }
            }

            //' I used the following text as an outline in developing this...
            // populate a hash with fixed_up(CustomerName) as key and CustomerID as value
            //     fixed_up defined as:  Uppercase(replace( spaces, periods, ampersands, commas, other? with NOTHING))
            //         so:  A.B.C Corp  --> ABCCorp
            //         key_down event should:
            //                take the Uppercase of <the input keystroke> 
            //            and
            //                add it to the <search string>
            // then you can seek on <search string> within the hash such that:
            //   <searchstring> = key
            // and set txtCustomerList.selected <there>
            // then you can populate the form view based on the selected record.
            //  this should work
            //  but first clean this up:
            //    a: populate one collection and use it in all the subroutines
            //    b: create and use a query object for seeking
            //           use: vCustomerlist.FetchByID(CustomerTableID) 
            //    c: examine and fixup the pickup table rows. 
            //           how many are there?
            //             per CustomerID?   
            //           how many should there be?
            //       here are the business rules:
            //           for a given customer id 
            //              if date is blank --- create a row with at least one monday tuesday... checked
            //              if date is not blank
            //              create a row for that date 
            //                   this row should have monday, tuesday, .... all UNCHECKED
            //              if date < today 
            //                  create a default row (with all 5 days checked
            //                   delete the row

            return CustListHash;
        }
        public static Hashtable PopulateRoute2Hash()
        {

            foreach (ROUTE2 route2 in mRoute2Collection.load())
            {
                // adds to the hash if not yet there
                // changes it if it IS already there
                // i.e. this is an "UPSERT"
                if ((route2.Route2TableID > 0))
                {
                    if (Route2Hash.Contains(route2.Route2TableID))
                    {
            // TODO:  replace w/ LINQ expression?
                        //Update it -- Last ONE wins
            //            Route2Hash.Item(route2.Route2TableID) = route2;
                    }
                    else
                    {
                        //Create it
                        Route2Hash.Add(route2.Route2TableID, route2);
                    }
                }
            }
            return Route2Hash;
        }


    }

}
