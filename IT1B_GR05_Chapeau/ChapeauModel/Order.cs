using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Order
    {
        public List<OrderItem> OrderedItems { get; set; } // insert count of list into database.
        public int Order_Id { get; set; }
        public Table Table { get; set; }
        public Employee Employee { get; set; }
        public OrderStatus Order_Status { get; set; }
        public bool Is_Paid { get; set; }
        public string Order_Comment { get; set; }
        public DateTime Order_Time { get; set; }


        public Order(int orderID, Table tableNr, Employee employee, OrderStatus status, bool isPaid, string comment, DateTime ordertime)
        {
            Order_Id = orderID;
            Table = tableNr;
            Employee = employee;
            Order_Status = status;
            Is_Paid = isPaid;
            Order_Comment = comment;
            Order_Time = ordertime;
        }

        public Order()
        {

        }

    }
}
