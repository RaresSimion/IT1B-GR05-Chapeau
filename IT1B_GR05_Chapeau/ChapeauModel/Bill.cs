using System;

namespace ChapeauModel
{
    public class Bill
    {
        public int Bill_ID { get; set; }
        public PaymentType Payment_Method { get; set; }
        public Table Table { get; set; }
        public decimal Total_Price { get; set; }
        public decimal Vat21 { get; set;}
        public decimal Vat6 { get; set;}



        public Bill()
        {

        }
        public Bill(int Bill_ID, PaymentType Payment_Method, Table Table, decimal Total_Price, decimal Vat21, decimal Vat6)
        {
            this.Bill_ID = Bill_ID;
            this.Payment_Method = Payment_Method;
            this.Table = Table;
            this.Total_Price = Total_Price;
            this.Vat21 = Vat21;
            this.Vat6 = Vat6;
        }
    }
}

