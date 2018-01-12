using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /*
        ** A class should take one responsibility and there should be one reason to change that class
     */
    class Customer // Correct
    {
        public void AddNewCustomer()
        {

        }

        public void GetCustomer()
        {

        }
    }
    class Payment // Correct
    {
        public void MakePayment()
        {
        }
    }

    // Below class violates the SRP. Because it has functions for both Customer & Payment.Tomorrow if we are changing Payment method
    // Customer method also needs to be tested
    class CustomerPayment // Wrong
    {
        public void AddNewCustomer()
        {

        }
        public void GetCustomer()
        {

        }
        public void MakePayment()
        {
        }
    }

    // Below class violates the SRP. Because it has functions for both Customer & WriteLog.Tomorrow if we are wrting logs from text file to
    // Email , Customer method also needs to be tested
    class CustomerErrorLog // Wrong
    {
        public void AddNewCustomer()
        {

        }
        public void GetCustomer()
        {

        }
        public void WriteLog()
        {
            // writing into log file
        }
    }

}
