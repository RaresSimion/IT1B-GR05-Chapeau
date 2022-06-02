using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauModel
{
    public class BillService
    {
        BillDAO billDB;
        public BillService()
        {
            billDB = new BillDAO();
        }
        public void GetAllBills()
        {
            billDB.GetAllBills();
        }

        public void GetBillByTableNrAndOrderItemID(Bill bill)
        {
            billDB.GetBillByTableNrAndOrderItemID(bill);
        }
    }
}