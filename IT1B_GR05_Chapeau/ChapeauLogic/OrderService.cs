using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderService
    {
        private OrderDAO orderDB;

        public OrderService()
        {
            orderDB = new OrderDAO();
        }

        public void InsertOrder(Order order)
        {
            orderDB.InsertOrder(order);
        }
    }
}
