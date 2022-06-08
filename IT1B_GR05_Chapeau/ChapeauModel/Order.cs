using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Order
    {
        //the list of order items in an order
        public List<OrderItem> OrderedItems { get; set; }

        //the id of the order
        public int Order_Id { get; set; }

        //the table where the order is taken
        public Table Table { get; set; }

        //the waiter who takes the order
        public Employee Employee { get; set; }

        //the status of the order
        public OrderStatus Order_Status { get; set; }

        //whether the order is paid or not
        public bool Is_Paid { get; set; } //0 = not paid, 1 = paid

        //the time when the order was placed
        public DateTime Order_Time { get; set; }

        //calculated property to get the number of items in the order
        public int Item_Count
        {
            get
            {
                int count = 0;
                foreach(OrderItem item in OrderedItems)
                    count += item.Order_Item_Quantity; //the count is increased based on the quantity of a specific item

                return count;
            }
        }

        //constructor
        public Order(List<OrderItem> orderItems, Table table, Employee employee, OrderStatus status, bool isPaid, DateTime ordertime)
        {
            OrderedItems = orderItems;
            Table = table;
            Employee = employee;
            Order_Status = status;
            Is_Paid = isPaid;
            Order_Time = ordertime;
        }

        //constructor
        public Order() { }
    }
}
