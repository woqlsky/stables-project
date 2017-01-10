using WindowsFormsApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Interfaces
{
    public interface IPayment
    {
        IEnumerable<Visit> GetVisit();

        IEnumerable<Payment> GetPayment();
        int insertPayment(Payment newPayment);
        bool updatePayment(Payment payment);
        bool deletePayment(Payment paymentDelete);

    }
}
