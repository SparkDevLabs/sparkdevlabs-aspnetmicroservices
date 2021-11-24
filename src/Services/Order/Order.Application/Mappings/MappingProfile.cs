using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Domain.Entities;
using Order.Application.Features.Orders.Queries.GetOrdersList;
using Order.Application.Features.Orders.Commands.CheckoutOrder;
using Order.Application.Features.Orders.Commands.UpdateOrder;

namespace Order.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order.Domain.Entities.Order, OrdersVM>().ReverseMap();
            CreateMap<Order.Domain.Entities.Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order.Domain.Entities.Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}
