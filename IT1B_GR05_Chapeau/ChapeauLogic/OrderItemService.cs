using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderItemService
    {
        OrderItemDAO orderItemDB;
        public OrderItemService()
        {
            //create connection to database
            orderItemDB = new OrderItemDAO();
        }

        //inserting an order item into the database
        public void InsertOrderItem(OrderItem orderItem)
        {
            orderItemDB.InsertOrderItem(orderItem);
        }

        //updating an order item with a new quantity or comment
        public void UpdateOrderItem(OrderItem orderItem)
        {
            orderItemDB.UpdateOrderItem(orderItem);
        }

        //get all order items by an id
        public List<OrderItem> GetItems(int ID)
        {
            return orderItemDB.GetOrderItemsByOrderID(ID);
        }

        //get all order items by the table
        public List<OrderItem> GetAllOrderItemsFromTable(Table table)
        {
            return orderItemDB.GetAllOrderItemsFromTable(table);
        }


    }
}
