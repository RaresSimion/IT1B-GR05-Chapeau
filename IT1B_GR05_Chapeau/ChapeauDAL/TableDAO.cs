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

        //public Table GetTable(int tablenr)
        //{
        //    //UPDATE LATER   string query = "SELECT FROM [TABLE]"
        //    // SqlParameter[] sqlParameter = { new SqlParameter("@table_id", tablenr) };
        //    //  return ReadTable(ExecuteSelectQuery(query, sqlParameter));
        //}

        public List<Table> GetAllTables()
        {
            string query = "SELECT * FROM [TABLE]";
            SqlParameter[] sqlParameter = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameter));
        }

        //update later
        private Table ReadTable(DataTable dataTable)
        {
            Table table = null;

            foreach (DataRow dataRow in dataTable.Rows)
            {
                table = new Table()
                {
                    Table_Number = (int)(dataRow[""]),
                    Table_Capacity = (int)(dataRow[""]),
                    Table_Availability = (TableAvailability)Enum.Parse(typeof(TableAvailability), dataRow[""].ToString())
                };
            }
            return table;
        }
        
        //update later
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach(DataRow dataRow in dataTable.Rows)
            {
                Table table = new Table()
                {
                    Table_Number = (int)(dataRow[""]),
                    Table_Capacity = (int)(dataRow[""]),
                    Table_Availability = (TableAvailability)Enum.Parse(typeof(TableAvailability), dataRow[""].ToString())
                };
                tables.Add(table);
            }
            return tables;
        }
        //update later
        public void UpdateTable(Table table)
        {

        }
    }
}