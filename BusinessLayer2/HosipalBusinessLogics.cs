using HMSEntity;
using System;
using System.Collections.Generic;

namespace BusinessLayer2
{
    public class HosipalBusinessLogics
    {
        List<Hospital> hospitalList = new List<Hospital>();
        public List<Hospital> GetHospitalDetails()
        {
            Hospital obj = new Hospital();
            obj.HosptialId = 1;
            obj.HosptialName = "Balaji Hospital";
            obj.Services = "Heart, General, kidney";
            obj.Speciality = "kidney";
            obj.HosptialDescription = "This hospital located near Guindy";
            obj.DoctorsCount = 25;
            obj.Dean = "Rajsh";

            Hospital obj1 = new Hospital();
            obj.HosptialId = 2;
            obj.HosptialName = "MMM Hospital";
            obj.Services = "Heart, General, kidney";
            obj.Speciality = "kidney";
            obj.HosptialDescription = "This hospital located near Guindy";
            obj.DoctorsCount = 25;
            obj.Dean = "Rajsh";

            Hospital obj2 = new Hospital();
            obj.HosptialId = 3;
            obj.HosptialName = "Global Hospital";
            obj.Services = "Heart, General, kidney";
            obj.Speciality = "kidney";
            obj.HosptialDescription = "This hospital located near Guindy";
            obj.DoctorsCount = 25;
            obj.Dean = "Rajsh";

            Hospital aObj = new Hospital()
            {
                Dean = "Vignesh",
                DoctorsCount = 100,
                HosptialDescription = "Famous Hospital in Chennai",
                Speciality = "Heart",
                Services = "General,Neuro,Metro,ortho",
                HosptialName = "Apollo Hospitals",
                HosptialId = 4
            };

            hospitalList.Add(obj);
            hospitalList.Add(obj1);
            hospitalList.Add(obj2);
            hospitalList.Add(aObj);

            return hospitalList;
        }
    }
}
