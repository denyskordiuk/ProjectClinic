using Project.Models.Entities;
using System.Collections.Generic;

namespace Project.Models.Services
{
    public interface IDataManagement
    {
        Client GetClient(string number);
        IList<Client> GetClients(string substring = null);
        Doctor GetDoctor(string number);
        IList<Doctor> GetDoctors(DoctorStatus? doctorStatus = null);
        Order GetOrder(string number);
        IList<Order> GetOrders(SortOrderType sortOrderType = SortOrderType.Desc, string substring = null);
    }
}