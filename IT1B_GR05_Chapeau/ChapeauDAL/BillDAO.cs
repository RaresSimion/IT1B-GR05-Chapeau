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
            string query = "SELECT BILL_ID, PAYMENT_METHOD, ORDER_ITEM_ID, TABLE_NR, TOTAL_PRICE FROM BILL";
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
                    Bill_ID = (int)(row["BILL_ID"]),
                    Payment_Method = (PaymentType)(row["PAYMENT_METHOD"]),
                    Order_Item_ID = (int)(row["ORDER_ITEM_ID"]),
                    Table_Nr = (int)(row["TABLE_NR"]),
                    Total_Price = ((double)row["TOTAL_PRICE"])
                };
                bills.Add(bill);
            }
            return bills;
        }

        public List<Bill> GetBillByTableNrAndOrderItemID(Bill bill)
        {
            string query = $"SELECT BILL_ID = {bill.Bill_ID}, PAYMENT_METHOD = {bill.Payment_Method}, ORDER_ITEM_ID = {bill.Order_Item_ID}, TABLE_NR = {bill.Table_Nr}, TOTAL_PRICE = {bill.Total_Price} FROM BILL WHERE TABLE_NR = {bill.Table_Nr} AND ORDER_ITEM_ID = {bill.Order_Item_ID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Bill> bills = new List<Bill>();
            return ReadBill(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}

