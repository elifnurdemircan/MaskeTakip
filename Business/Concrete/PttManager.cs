﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities1.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService 
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //constructor new yapıldığında çalışır.
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
           
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "icin maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " icin maske VERİLEMEDİ");
            }
        }
    }
}
