using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class TableDAO : BaseDao
    {
        private SqlConnection databaseConnection;

        public Table GetTable(int tablenr)
        {
            string query = $"SELECT TABLE_ID, TABLE_CAPACITY, TABLE_AVAILABILITY FROM [TABLE] WHERE TABLE_ID = {tablenr}";
                SqlParameter[] sqlParameter = { new SqlParameter("@TABLE_ID", tablenr) };
            return ReadTable(ExecuteSelectQuery(query, sqlParameter));
        }



        //read 1 

        private Table ReadTable(DataTable dataTable)
        {
            Table table = null;

            foreach (DataRow dataRow in dataTable.Rows)
            {
                table = new Table()
                {
                    Table_Number = (int)(dataRow["TABLE_ID"]),
                    Table_Capacity = (int)(dataRow["TABLE_CAPACITY"]),
                    Table_Availability = (TableAvailability)Enum.Parse(typeof(TableAvailability), dataRow["TABLE_AVAILABILITY"].ToString())
                };
            }
            return table;
        }


        public void UpdateTable(Table table)
        {

        }
    }
}