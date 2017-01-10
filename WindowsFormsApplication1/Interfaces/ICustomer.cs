using WindowsFormsApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Interfaces
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetCustomer();
        int insertCustomer(Customer newCustomer);
        bool updateCustomer(Customer customer);
        bool deleteCustomer(Customer customerDelete);
    }
}
