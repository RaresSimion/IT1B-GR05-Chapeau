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
    public class BillDAO : BaseDao
    {
        private SqlConnection databaseConnection;

        public BillDAO()
        {

        }

        public List<Bill> GetAllBills()
        {
            string query = "SELECT Bill_ID, Payment_Method, Order_ID, Table_Nr, Total_Price FROM Bill";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Bill> bills = new List<Bill>();
            return ReadBill(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Bill> ReadBill(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();
            Bill bill = null;
            foreach (DataRow row in dataTable.Rows)
            {
                bill = new Bill()
                {
                    Bill_ID = (int)(row["Bill_ID"]),
                    Payment_Method = (PaymentType)(row["Payment_Method"]),
                    Order_ID = (int)(row["Order_ID"]),
                    Table_Nr = (int)(row["Table_Nr"]),
                    Total_Price = ((double)row["Total_Price"])
                };
                bills.Add(bill);
            }
            return bills;
        }

        public List<Bill> GetBillByTableNrAndOrderID()
        {
            string query = "SELECT Bill_ID, Payment_Method, Order_ID, Table_Nr, Total_Price FROM Bill WHERE Table_Nr = @TableNR AND order_ID = @orderId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Bill> bills = new List<Bill>();
            return ReadBill(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}

