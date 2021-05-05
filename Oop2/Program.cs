using System;

namespace Oop2
{



    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerNumber = "1234";
            customer1.Id = 1;

            Individual individual = new Individual();
            individual.Id = 2;
            individual.IdNumber = "12345566";
            individual.LastName = "ddd";
            individual.Name = "wwww";
            individual.CustomerNumber = "7708098976";



            Corporate corporate = new Corporate();
            corporate.CompanyName = "dd";
            corporate.CustomerNumber = "234";
            corporate.Id = 456;
            corporate.TaxIdNumber = "34fg44";

            Customer customer = new Corporate();
            customer.Id = 1;

            // we can descirabe a object from paren class to inherint calss
            customer.CustomerNumber = "234455";
            customer.Id = 257;
            // we can access just Corporate class proporties 


        }
    }
}
 