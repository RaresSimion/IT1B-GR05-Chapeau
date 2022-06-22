using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;
using ChapeauModel;

namespace ChapeauDAL
{
    public abstract class BaseDao
    {
        private SqlDataAdapter adapter;
        private SqlConnection conn;



        public BaseDao()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chapeau"].ConnectionString);
            adapter = new SqlDataAdapter();
        }



        protected SqlConnection OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                ErrorLogger.LogError(e); //error log
                throw;
            }
            return conn;
        }



        private void CloseConnection()
        {
            conn.Close();
        }



        /* For Insert/Update/Delete Queries with transaction */
        protected void ExecuteEditTranQuery(string query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand command = new SqlCommand(query, conn, sqlTransaction);
            try
            {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ErrorLogger.LogError(e);
                //throw;
            }
        }



        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();


            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                ErrorLogger.LogError(e);
                throw new Exception("Unable to execute edit query, check the syntax");
            }
            finally
            {
                CloseConnection();
            }
        }



        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();



            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                ErrorLogger.LogError(e); //error log
                throw new Exception("Unable to execute select query, check the syntax");
                //return null;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }

        /* For Select Queries without parameters*/
        protected DataTable ExecuteSelectQuery(string query)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();



            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                ErrorLogger.LogError(e); //error log
                throw new Exception("Unable to execute select query, check the syntax");
                //return null;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }
    }
}
