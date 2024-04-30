using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesRepository.Data_Access_Layer
{
    public interface ICustomerRepository
    {
        List<Customer> Get();
        Customer Get(int customerid);
        bool Add(Customer model);
        bool Update(Customer model);
        bool Delete(int id);
    }
}
