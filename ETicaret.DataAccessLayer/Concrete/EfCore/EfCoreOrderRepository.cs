using ETicaret.DataAccessLayer.Abstract;
using ETicaret.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Concrete.EfCore
{
    public class EfCoreOrderRepository : EfCoreGenericRepository<Order, ETicaretContext>, IOrderRepository
    {
        public List<Order> GetOrders(string userId)
        {
            using (var context = new ETicaretContext())
            {
                List<Order> orders = context.Orders
                    .Include(o => o.OrderItems)
                    .ThenInclude(o=> o.Product)
                    .Where(o => o.UserId == userId)
                    .ToList();

                return orders;
            }
        }
    }
}
