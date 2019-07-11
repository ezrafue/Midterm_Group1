using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Payroll.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Payroll.Controllers
{
    public class PayrollController : Controller
    {
        public PayrollModel objPayroll;

        // GET: /<controller>/
        public ActionResult Home()
        {
            this.objPayroll = new PayrollModel();
            return View();

        }

    }
}
