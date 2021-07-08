﻿using Project.Models.Entities;
using System.Collections.Generic;

namespace Project.Models.Services
{
    public interface ICommonDataManagement
    {
        Client GetClient(string number);
        IList<Client> GetClients(string substring = null);
        string AddClient(Client client);
        string UpdateClient(string phoneNumber, Client model);
        void DeleteClient(string phoneNumber);
        Doctor GetDoctor(string number);
        IList<Doctor> GetDoctors(DoctorStatus? doctorStatus = null);
        string AddDoctor(Doctor doctor);
        string UpdateDoctor(string doctorLicense, Doctor model);
        void DeleteDoctor(string doctorLicense);
    }
}