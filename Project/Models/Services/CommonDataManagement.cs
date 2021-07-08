using Project.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Services
{
    public class CommonDataManagement : ICommonDataManagement
    {
        private IList<Doctor> _doctors = new List<Doctor>();
        private IList<Client> _clients = new List<Client>();


        public CommonDataManagement()
        {
            _doctors.Add(new Doctor
            {
                License = "568485D",
                DoctorName = "Ivan",
                Experience = 2,
                PhoneNumber = "0983458752",
                Cabinet = 420
            });

            _doctors.Add(new Doctor
            {
                License = "596712O",
                DoctorName = "Ruslan",
                Experience = 6,
                PhoneNumber = "0983416582",
                Cabinet = 27
            });

            _doctors.Add(new Doctor
            {
                License = "165156K",
                DoctorName = "Georg",
                Experience = 9,
                PhoneNumber = "0975616593",
                Cabinet = 84
            });

            _doctors.Add(new Doctor
            {
                License = "1941568N",
                DoctorName = "Dion",
                Experience = 3,
                PhoneNumber = "0501097426",
                Cabinet = 301
            });

            _doctors.Add(new Doctor
            {
                License = "789456I",
                DoctorName = "Yosup",
                Experience = 15,
                PhoneNumber = "0506359748",
                Cabinet = 112
            });


            _clients.Add(new Client
            {
                FullName = "Artur Kirovish",
                Age = 19,
                Adress = "Lviv",
                Mail = "artur@gmail.com",
                PhoneNumber = "0685268750",
                PayMethod = PayMethod.Cash
            });

            _clients.Add(new Client
            {
                FullName = "Andry Sternenkin",
                Age = 24,
                Adress = "Odessa",
                Mail = "andry.odesskiy@gmail.com",
                PhoneNumber = "0508478592",
                PayMethod = PayMethod.DebitCard
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
            var result = _clients;
            if (substring is not null)
            {
                result = result.Where(x => x.PhoneNumber == substring).ToList();
            }
            return result;
        }

        public Client GetClient(string number)
        {
            return _clients.SingleOrDefault(x => x.PhoneNumber.Contains(number,
               StringComparison.InvariantCultureIgnoreCase));
        }

        public string AddDoctor(Doctor doctor)
        {
            _doctors.Add(doctor);
            return doctor.License;
        }

        public string UpdateDoctor(string doctorLicense, Doctor model)
        {
            var doctor = GetDoctor(doctorLicense);
            doctor.License = model.License;
            doctor.Experience = model.Experience;
            doctor.PhoneNumber = model.PhoneNumber;
            doctor.Cabinet = model.Cabinet;
            doctor.DoctorStatus = model.DoctorStatus;

            return model.License;
        }

        public void DeleteDoctor(string doctorLicense)
        {
            var doctor = GetDoctor(doctorLicense);
            _doctors.Remove(doctor);
        }

        public string AddClient(Client client)
        {
            _clients.Add(client);
            return client.PhoneNumber;
        }

        public string UpdateClient(string phoneNumber, Client model)
        {
            var client = GetClient(phoneNumber);
            client.FullName = model.FullName;
            client.PhoneNumber = model.PhoneNumber;
            client.Age = model.Age;
            client.Adress = model.Adress;
            client.Mail = model.Mail;
            client.PayMethod = model.PayMethod;


            return model.PhoneNumber;
        }

        public void DeleteClient(string phoneNumber)
        {
            var client = GetClient(phoneNumber);
            _clients.Remove(client);
        }
    }
}