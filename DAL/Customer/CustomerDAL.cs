using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using DAL.Interface;

namespace DAL.Customer
{
    public class CustomerDAL : IDAL
    {
        private SqlConnection _connection = null;

        #region IDAL Members

        public DataTable GetAll()
        {
            DataTable customer = new DataTable();
            using (_connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["jake"].ConnectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM CUSTOMERS";
                command.CommandType = CommandType.Text;
                command.Connection = _connection;
                _connection.Open();

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                customer.Load(reader);
                _connection.Close();
            }

            return customer;
        }

        public DataTable GetById(string ID)
        {
            DataTable customers = new DataTable();
            using (_connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["jake"].ConnectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM CUSTOMERS WHERE CustomerID = @CustomerID";
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("@CustomerID", ID));
                command.Connection = _connection;
                _connection.Open();

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                customers.Load(reader);
                _connection.Close();
            }

            return customers;
        }

        public bool SaveOrUpdate(DataTable entity)
        {
            return true;
        }

        #endregion
    }
}
