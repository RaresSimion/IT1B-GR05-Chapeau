﻿using System;
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
            string query = $"SELECT TABLE_ID, TABLE_CAPACITY, TABLE_AVAILABILITY FROM [TABLES] WHERE TABLE_ID = @TABLE_ID;";
            SqlParameter[] sqlParameter = { new SqlParameter("@TABLE_ID", (int)tableNr) };
            return ReadTable(ExecuteSelectQuery(query, sqlParameter));
        }

        public List<Table> GetAllTables()
        {
            string query = $"SELECT TABLE_ID, TABLE_CAPACITY, TABLE_AVAILABILITY FROM [TABLES]";
            return ReadTables(ExecuteSelectQuery(query));
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

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table();
                {
                    table.Table_Number = (int)(dr["TABLE_ID"]);
                    table.Table_Capacity = (int)(dr["TABLE_CAPACITY"]);
                    table.Table_Availability = (bool)(dr["TABLE_AVAILABILITY"]);
                }
                tables.Add(table);
            }
            return tables;
        }

        public void UpdateTable(int tableNr, bool tableAvailability)
        {
            string query = $"UPDATE [TABLES] SET TABLE_AVAILABILITY = '@TABLE_AVAILABILITY' WHERE TABLE_ID = '@TABLE_ID'";
            SqlParameter[] sqlParameter = { new SqlParameter("@TABLE_AVAILABILITY", (bool)tableAvailability), new SqlParameter("@TABLE_ID", (int)tableNr) };
            ExecuteEditQuery(query, sqlParameter);
        }
    }
}