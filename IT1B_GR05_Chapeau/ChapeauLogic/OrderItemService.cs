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
            orderItemDB = new OrderItemDAO();
        }

        public void InsertOrderItem(OrderItem orderItem)
        {
            orderItemDB.InsertOrderItem(orderItem);
        }
    }
}
