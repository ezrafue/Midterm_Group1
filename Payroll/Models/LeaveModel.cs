using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class LeaveModel
    {
        public string id { get; set; }
        public string department { get; set; }
        public string leavedays { get; set; }
        public string reason { get; set; }
        public string other { get; set; }

        public void AddLeaveEF()
        {
            using (CMSContext cntxt = new CMSContext())
            {
                cntxt.Database.EnsureCreated();
                cntxt.Leave.Add(new LeaveModel
                {
                    id = this.id,
                    department = this.department,
                    leavedays = this.leavedays,
                    reason = this.reason,
                    other = this.other
                });
                cntxt.SaveChanges();
            }
        }
    }
}
