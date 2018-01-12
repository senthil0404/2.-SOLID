using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //This principle states that any client should not be forced to use an interface which is irrelevant to it.
    //First we created an Interface with only Read from Database
    // Later we are introducting Update Customer.so we should not force existing client to force class to implement update Method

    public interface IReadData
    {
        string ReadData();
    }

    public interface IUpdateData : IReadData
    {
        string UpdateData();
    }

    public class CustomerISP : IReadData, IUpdateData
    {
        public string ReadData()
        {
            return "";
        }
        public string UpdateData()
        {
            return "";
        }
    }
}
