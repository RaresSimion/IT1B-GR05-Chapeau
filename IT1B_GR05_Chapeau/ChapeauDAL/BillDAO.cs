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
        private TableDAO tableDAO = new TableDAO();

        public BillDAO()
        {

        }
        /* public List<Bill> GetBillByTableNr(Order tableNr)
        {
            string query = $"SELECT BILL_ID = {bill.Bill_ID}, PAYMENT_METHOD = {bill.Payment_Method}, TABLE_NR = {bill.Table_Nr}, TOTAL_PRICE = {bill.Total_Price}, VAT06 = {bill.Vat6}, VAT21 = {bill.Vat21} FROM BILL WHERE TABLE_NR = {bill.Table_Nr}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Bill> bills = new List<Bill>();
            return ReadBill(ExecuteSelectQuery(query, sqlParameters));
        }*/
        public void InsertBill(Bill bill)
        {
            string query = $"INSERT INTO BILL VALUES({bill.Total_Price}, {(int)bill.Payment_Method}, {bill.Table}, {bill.Vat21}, {bill.Vat6})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        /*private List<Bill> ReadBill(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();
            Bill bill = null;
            foreach (DataRow row in dataTable.Rows)
            {
                bill = new Bill()
                {
                    Bill_ID = (int)(row["BILL_ID"]),
                    Payment_Method = (PaymentType)(row["PAYMENT_METHOD"]),
                    Table = tableDAO.GetTable((int)(row["TABLE_ID"])),
                    Total_Price = ((decimal)row["TOTAL_PRICE"]),
                    Vat6 = ((decimal)row["VAT06"]),
                    Vat21 = ((decimal)row["VAT21"])
                };
                bills.Add(bill);
            }
            return bills;
        }*/
    }
}

