using System;
using System.Collections.Generic;

namespace Oop3Interface
{
    partial class Program
    { 

        static void Main(string[] args)
        {
            ConsumerLoan consumerLoan = new ConsumerLoan();
            consumerLoan.Calculate();

            ICreditManager consumerLoan1 = new ConsumerLoan();  // We cab assign a inheritence a subclass. In  other words an inheritance can take a implement class as a reference
            consumerLoan1.Calculate();
           
            VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
            vehicleLoanManager.Calculate();

            MortgageManager mortgageManager = new MortgageManager();
            mortgageManager.Calculate();



            Console.WriteLine(".........................................................*********************************......................................................");


            ICreditManager consumerLoan2 = new ConsumerLoan();
            ICreditManager vehicleManager2 = new VehicleLoanManager();
            ICreditManager mortgageManager2 = new MortgageManager();

            // We create a class which is common for all other classes and we use it .







            ApplicationManager applicationManager = new ApplicationManager();

            applicationManager.Apply(consumerLoan2);  
            applicationManager.Apply(vehicleManager2);
            applicationManager.Apply(mortgageManager2);
            Console.WriteLine("................................"+ "."+ ".+" + "." + "********************************");
            List<ICreditManager> credits = new List<ICreditManager>() { consumerLoan2, vehicleManager2 , mortgageManager2 };  // I defined an empty class

            applicationManager.CreditEvaluation(credits);

            


        }
    }
}
