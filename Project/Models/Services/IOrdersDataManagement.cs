using Project.Models.Entities;
using System.Collections.Generic;

namespace Project.Models.Services
{
    public interface IOrdersDataManagement
    {
        Order GetOrder(string number);
        IList<Order> GetOrders(SortOrderType sortOrder = SortOrderType.Desc, string substring = null);
    }
}