using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /* Dependency inversion principle is a software design principle which provides us the guidelines to write loosely coupled classes.
            ***********    According to the definition of Dependency inversion principle: ***********    
            1.High-level modules should not depend on low-level modules. Both should depend on abstractions.
            2.Abstractions should not depend upon details. Details should depend upon abstractions 
    */

    /*
     * 
     * 1) The Dependency Inversion principle (DIP) helps us to develop loosely couple code by ensuring that high-level modules depend on 
     *    abstractions rather than concrete implementations of lower-level modules.
     * 2) The Inversion of Control(IOC) pattern is an implementation of this principle
     * 3) Inversion of Control(IOC) pattern can be implemented in 2 ways.
            a)  Dependency injection :- DI is a subtype of IOC and is implemented by constructor injection, setter injection or method injection.
            b)  Service Locator
        
        Example : 
            1) Suppose your Client class needs to use a Service class component, then the best you can do is to make your Client class
                aware of an IService interface rather than a Service class. 
            2) In this way, you can change the implementation of the Service class at any time(and for how many times you want) without breaking the host code.

    */

    class Wrong_DependencyInversionPrinciple // Wrong Tightly Coupled
{
    public class Email
    {
        public void SendEmail()
        {
            // code to send mail
        }
    }

    //Now Notification class totally depends on Email class, because it only sends one type of notification.
    //If we want to introduce any other like SMS then? We need to change the notification system also.
    public class Notification
    {
        private Email _email;
        public Notification()
        {
            _email = new Email();
        }

        public void PromotionalNotification()
        {
            _email.SendEmail();
        }
    }
}

class Wrong_DIP2
{
    //Still Notification class depends on Email class. Now, we can use dependency injection so that we can make it loosely coupled.
    //There are 3 types to DI, Constructor injection, Property injection and method injection.
    public interface IMessenger
    {
        void SendMessage();
    }
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            // code to send email
        }
    }

    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            // code to send SMS
        }
    }
    public class Notification
    {
        private IMessenger _iMessenger;
        public Notification()
        {
            _iMessenger = new Email();
        }
        public void DoNotify()
        {
            _iMessenger.SendMessage();
        }
    }
}


 public interface IMessenger
    {
        void SendMessage();
    }
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            // code to send email
        }
    }
    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            // code to send SMS
        }
    }

public class Dependency_Injection_Notification
{
    private IMessenger _iMessenger;

    public Dependency_Injection_Notification(IMessenger pMessenger)   //   Constructor Injection
    {
        _iMessenger = pMessenger; //  In this constructor Object is assigned
    }

    public IMessenger MessageService // Property Injection
    {
        private get
        {
            return _iMessenger;
        }
        set
        {
            _iMessenger = value;  //  In this Property Object is assigned
        }
    }

    public void DoNotify(IMessenger pMessenger) // Method Injection
    {
        pMessenger.SendMessage();
    }

    public void DoNotify()
    {
        _iMessenger.SendMessage();
    }
}

public class Property_Injection_Notification
{
    public interface IMessenger
    {
        void SendMessage();
    }
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            // code to send email
        }
    }

    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            // code to send SMS
        }
    }
    private IMessenger _iMessenger;
//  In this property Object is assigned
    public IMessenger MessageService
    {
        get
        {
            return _iMessenger;
        }
        set
        {
            _iMessenger = value;
        }
    }

    public void DoNotify()
    {
        _iMessenger.SendMessage();
    }

    // Method Injection
    public void DoNotify(IMessenger pMessenger)
    {
        pMessenger.SendMessage();
    }

}
}
