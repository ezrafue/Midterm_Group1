using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class PayrollModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Numdays { get; set; }
        public string Rateday { get; set; }
        public string Deductions { get; set; }
        public string SSS { get; set; }
        public string Philhealth { get; set; }

        public void AddLeaveEF()
        {
            using (CMSContext cntxt = new CMSContext())
            {
                cntxt.Database.EnsureCreated();

                cntxt.Payroll.Add(new PayrollModel
                {    
                    Id = this.Id,
                    Name = this.Name,
                    Dept = this.Dept,
                    Numdays = this.Numdays,
                    Rateday = this.Rateday,
                    Deductions = this.Deductions,
                    SSS = this.SSS,
                    Philhealth = this.Philhealth
                });

                cntxt.SaveChanges();

            }
        }
    }
}
