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
        public Table GetTable(int tableNr)
        {
            string query = $"SELECT TABLE_ID, TABLE_CAPACITY, TABLE_AVAILABILITY FROM [TABLES] WHERE TABLE_ID = {tableNr};";
            SqlParameter[] sqlParameter = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameter));
        }



        //read 1 

        private Table ReadTable(DataTable dataTable)
        {
            DataRow dataRow = dataTable.Rows[0];
            Table table = new Table()
            {
                Table_Number = (int)(dataRow["TABLE_ID"]),
                Table_Capacity = (int)(dataRow["TABLE_CAPACITY"]),
                Table_Availability = (bool)(dataRow["TABLE_AVAILABILITY"])
            };

            return table;
        }


        public void UpdateTable(Table table)
        {

        }
    }
}