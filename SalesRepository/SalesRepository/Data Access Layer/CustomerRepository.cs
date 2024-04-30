using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesRepository.Data_Access_Layer
{
    public class CustomerRepository : ICustomerRepository
    {
        List<Customer> listCustomer = new List<Customer>()
        {
            new Customer(1, "Faisal", "Dhaka"),
            new Customer(2, "Adnan", "Feni"),
            new Customer(3, "Neoyaz", "Cumilla"),
            new Customer(4, "Fatiha", "Jessore")
        };
        public List<Customer> Get()
        {
            return listCustomer.OrderBy(x => x.CustomerName).ToList();
        }

        public Customer Get(int id)
        {
            Customer oCustomer = listCustomer.Where(x => x.CustomerId == id).FirstOrDefault();
            return oCustomer;
        }

        public bool Add(Customer model)
        {
            listCustomer.Add(model);
            return true;
        }

        public bool Update(Customer model)
        {
            bool isExecuted = false;
            Customer oCustomer = listCustomer.Where(x => x.CustomerId == model.CustomerId).FirstOrDefault();
            if (oCustomer != null)
            {
                listCustomer.Remove(oCustomer);
                listCustomer.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int id)
        {
            bool isExecuted = false;
            Customer oCustomer = listCustomer.Where(x => x.CustomerId == id).FirstOrDefault();
            if (oCustomer != null)
            {
                listCustomer.Remove(oCustomer);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
