using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {

        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    orders = context.Orders.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public static Order GetOrder(int id)
        {
            Order order;
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    order = context.Orders.FirstOrDefault(x => x.OrderId.Equals(id));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }

        public static void CreateOrder(Order order)
        {
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteOrder(Order order)
        {
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateOrder(Order order)
        {
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    var a = context.Orders.Update(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
