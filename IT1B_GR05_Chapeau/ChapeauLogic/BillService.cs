using System;

namespace ChapeauModel
{
    public class Bill
    {
        public int Bill_ID { get; set; }
        public PaymentType Payment_Method { get; set; }
        public int Order_ID { get; set; }
        public int Table_Nr { get; set; }
        public double Total_Price { get; set; }



        public Bill()
        {

        }
        public Bill(int Bill_ID, PaymentType Payment_Method, int Order_ID, int Table_Nr, double Total_Price)
        {
            this.Bill_ID = Bill_ID;
            this.Payment_Method = Payment_Method;
            this.Order_ID = Order_ID;
            this.Table_Nr = Table_Nr;
            this.Total_Price = Total_Price;
        }
    }
}