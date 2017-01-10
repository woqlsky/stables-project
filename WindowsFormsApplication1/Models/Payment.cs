using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Payment
    {
        public int pay_id { get; set; }
        public int for_which_visit { get; set; }
        public int sum_of_payment { get; set; }

    }
}
