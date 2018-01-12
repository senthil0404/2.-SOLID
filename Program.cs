using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // SOLID are five basic principles which allows to create a software with good architecture
    class Program
    {
        static void Main(string[] args)
        {
            // Invalid LSP
            List<Member> ob = new List<Member>();
            ob.Add(new AnnualMember());
            ob.Add(new LifetTimeMember());
            ob.Add(new EnquiryMember());

            foreach (var item in ob)
            {
                item.MakePayment();
            }

            // valid LSP
            List<SOLIDLSP.Member> ob1 = new List<SOLIDLSP.Member>();
            ob1.Add(new SOLIDLSP.AnnualMember());
            ob1.Add(new SOLIDLSP.LifetTimeMember());
          //  ob1.Add(new SOLIDLSP.EnquiryMember());

            foreach (var item in ob1)
            {
                item.MakePayment();
            }


            ///// Interface Segregation
            // Old clients continue to use old IReadData interface
            IReadData obISP = new CustomerISP();
            obISP.ReadData();

            // new clients will use new IUpdateData interface
            IUpdateData obISP1 = new CustomerISP();
            obISP1.ReadData();
            obISP1.UpdateData();


            //// Dependency_Injection_Notification
            IMessenger obIM = new Email();
            Dependency_Injection_Notification obDIP = new Dependency_Injection_Notification(obIM); // Constructor Injection
            obDIP.MessageService = obIM; // Property Injection
            obDIP.DoNotify(obIM); // Method Injection
        }
    }
}
