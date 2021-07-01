using Project.Models.Entities;
using System.Collections.Generic;

namespace Project.Models.Services
{
    public interface ICommonDataManagement
    {
        Client GetClient(string number);
        IList<Client> GetClients(string substring = null);
        Doctor GetDoctor(string number);
        IList<Doctor> GetDoctors(DoctorStatus? doctorStatus = null);
    }
}