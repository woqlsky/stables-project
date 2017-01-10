using WindowsFormsApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Interfaces
{
    public interface IVisit
    {
        IEnumerable<Horse> GetHorse();
        IEnumerable<Customer> GetCustomer();
        IEnumerable<Visit> GetVisit();
        int insertVisit(Visit newVisit);
        bool updateVisit(Visit visit);
        bool deleteVisit(Visit visitDelete);

    }
}
