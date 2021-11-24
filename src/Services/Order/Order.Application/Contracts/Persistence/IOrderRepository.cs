using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Domain.Entities;

namespace Order.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order.Domain.Entities.Order>
    {
        Task<IEnumerable<Order.Domain.Entities.Order>> GetOrdersByUserName(string userName);
    }
}
