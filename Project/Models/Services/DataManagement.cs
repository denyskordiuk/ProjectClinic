using Project.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Services
{
    public class DataManagement : IDataManagement
    {
        private IList<Doctor> _doctors = new List<Doctor>();
        private IList<Client> _clients = new List<Client>();
        private IList<Order> _orders = new List<Order>();


        public DataManagement()
        {
            _doctors.Add(new Doctor
            {
                License = "134585D",
                DoctorName = "Ivan",
                Experience = 2,
                PhoneNumber = "0983458752",
                Cabinet = 420
            });

            _doctors.Add(new Doctor
            {
                License = "596712H",
                DoctorName = "Ruslan",
                Experience = 6,
                PhoneNumber = "0983416582",
                Cabinet = 27
            });

            _doctors.Add(new Doctor
            {
                License = "134585D",
                DoctorName = "Georg",
                Experience = 9,
                PhoneNumber = "0975616593",
                Cabinet = 84
            });

            _doctors.Add(new Doctor
            {
                License = "134585D",
                DoctorName = "Dion",
                Experience = 3,
                PhoneNumber = "0501097426",
                Cabinet = 301
            });

            _doctors.Add(new Doctor
            {
                License = "134585D",
                DoctorName = "Yosup",
                Experience = 15,
                PhoneNumber = "0506359748",
                Cabinet = 112
            });

        }


        public IList<Doctor> GetDoctors(DoctorStatus? doctorStatus = null)
        {
            var result = _doctors;
            if (doctorStatus.HasValue)
            {
                result = result.Where(x => x.DoctorStatus == doctorStatus.Value).ToList();
            }

            return result;
        }

        public Doctor GetDoctor(string number)
        {
            return _doctors.SingleOrDefault(x => x.License.Contains(number,
               StringComparison.InvariantCultureIgnoreCase));
        }

        public IList<Client> GetClients(string substring = null)
        {
            throw new Exception("not implemented");
        }

        public Client GetClient(string number)
        {
            throw new Exception("not implemented");
        }

        public IList<Order> GetOrders(SortOrderType sortOrderType = SortOrderType.Desc, string substring = null)
        {
            throw new Exception("not implemented");
        }

        public Order GetOrder(string number)
        {
            throw new Exception("not implemented");
        }
    }
}