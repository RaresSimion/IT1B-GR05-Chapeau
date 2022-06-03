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
        public DateTime Order_Time { get; set; }
        public int Item_Count
        {
            get
            {
                int count = 0;
                foreach(OrderItem item in OrderedItems)
                    count += item.Order_Item_Quantity;

                return count;
            }
        }

        public Order(List<OrderItem> orderItems, Table table, Employee employee, OrderStatus status, bool isPaid, string comment, DateTime ordertime)
        {
            OrderedItems = orderItems;
            Table = table;
            Employee = employee;
            Order_Status = status;
            Is_Paid = isPaid;
            Order_Time = ordertime;
        }

        public Order() { }
    }
}
