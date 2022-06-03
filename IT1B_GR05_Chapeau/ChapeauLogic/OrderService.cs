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

        public void UpdateOrderStatus(int orderId, OrderStatus status) {
            orderDB.UpdateOrderStatus(orderId, status);
        }

         public List<Order> GetFoodOrders() {
            List<Order> orders = orderDB.GetFoodOrders();
            return orders;
         }
         public List<Order> GetDrinkOrders()
         {
            List<Order> orders = orderDB.GetDrinkOrders();
            return orders;
         }
        /*
         public Order GetOrderById(int orderId) {
            Order order = orderDB.GetOrderById(orderId);
            return order;
         }
        */
    }
}
