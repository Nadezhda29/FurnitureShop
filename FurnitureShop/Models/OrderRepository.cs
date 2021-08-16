using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FurnitureShop.Models
{
    public class OrderRepository: IOrderRepository
    {
        private AppDbContext context;

        public OrderRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders => context.Orders
            .Include(o => o.Lines)
            .ThenInclude(l => l.Furniture);

        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Furniture));

            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }

            context.SaveChanges();
        }
    }
}
