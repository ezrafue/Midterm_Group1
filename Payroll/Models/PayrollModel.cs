using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class PayrollModel
    {
        public int id { get; set; }
        public string dept { get; set; }
        public int numdays { get; set; }
        public int rateday { get; set; }
    }
}
