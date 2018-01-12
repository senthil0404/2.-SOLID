using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID //InvalidLSP
{
    //The Liskov Substitution Principle says that the object of a derived class should be able to replace an object of the base class 
    // without bringing any errors in the system or modifying the behavior of the base class
    // Enquiry Customer should not implement Member class.. Becasue its a different type of member

    public abstract class Member 
    {
        public abstract void AddtoDatabse();
        public abstract void MakePayment();
    }

    public class LifetTimeMember : Member
    {
        public override void AddtoDatabse()
        {
        }
        public override void MakePayment()
        {
        }
    }

    public class AnnualMember : Member
    {
        public override void AddtoDatabse()
        {
        }
        public override void MakePayment()
        {
        }
    }

    public class EnquiryMember : Member
    {
        public override void AddtoDatabse()
        {
        }
        public override void MakePayment()
        {
        }
    }
}

namespace SOLIDLSP //  Valid LSP
{
    public interface IAddCustomer
    {
        void AddtoDatabse();
    }
    public interface IPayment : IAddCustomer
    {
        void MakePayment();
    }

    public class Member : IPayment
    {
        public virtual void AddtoDatabse()
        {

        }
        public virtual void MakePayment()
        {
        }
    }

    public class LifetTimeMember : Member
    {
        public override void AddtoDatabse()
        {
        }
        public override void MakePayment()
        {
        }
    }

    public class AnnualMember : Member
    {
        public override void AddtoDatabse()
        {
        }
        public override void MakePayment()
        {
        }
    }

    public class EnquiryMember : IAddCustomer
    {
        public  void AddtoDatabse()
        {
        }
    }
}