using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class TableService
    {
        TableDAO tableDAO;

        public TableService()
        {
            tableDAO = new TableDAO();
        }

        public Table GetTable(int tableNr)
        {
            Table table = tableDAO.GetTable(tableNr);
            return table;
        }

        public void UpdateTable(int tableNr, bool tableAvailability)
        {
            tableDAO.UpdateTable(tableNr, tableAvailability);
        }

        public List<Table> GetTables()
        {
            List<Table> tables = tableDAO.GetAllTables();
            return tables;
        }
    }
}
