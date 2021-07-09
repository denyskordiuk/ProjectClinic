using Project.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Services
{
    public class OrdersDataManagement: IOrdersDataManagement
    {
        private readonly ICommonDataManagement _commonService;

        private IList<Order> _orders = new List<Order>();

        public OrdersDataManagement()
        {

        }


        public OrdersDataManagement(ICommonDataManagement commonService) 
        {
            _commonService = commonService;
        }

        public Order GetOrder(string number)
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetOrders(SortOrderType sortOrder = SortOrderType.Desc, string substring = null)
        {
            var result = _orders;
            result = result.ToList();
            return result;
        }
    }
}