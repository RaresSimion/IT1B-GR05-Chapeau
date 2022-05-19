using System;
using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;


namespace ChapeauLogic
{
    public class TableService
    {
        TableDAO tabledatabase;

        public TableService()
        {
            tabledatabase = new TableDAO();
        }

        //public Table GetTable(int tablenr)
        //{
        //    Table table = tabledatabase.GetTable(tablenr);
        //    return table;
        //}

        public List<Table> GetTables()
        {
            List<Table> tables = tabledatabase.GetAllTables();
            return tables;
        }

        public void UpdateTable(Table table)
        {
            tabledatabase.UpdateTable(table);
        }
    }
}
