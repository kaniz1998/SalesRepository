using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesRepository.Data_Access_Layer
{
    public class Customer
    {
        public int CustomerId;
        public string CustomerName;
        public string CustomerAddress;
        public Customer()
        {

        }
        public Customer(int customerid, string customername, string customeraddress)
        {
            CustomerId = customerid;
            CustomerName = customername;
            CustomerAddress = customeraddress;
        }
    }
}
