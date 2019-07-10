using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Payroll.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Payroll.Controllers
{
    public class LeaveController : Controller
    {
        public LeaveModel objLeave;
        // GET: /<controller>/
        public ActionResult Index()
        {
            this.objLeave = new LeaveModel();
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                this.objLeave = new LeaveModel();

                this.objLeave.id = collection["id"].ToString();

                this.objLeave.department = collection["department"].ToString();

                this.objLeave.leavedays = collection["leavedays"].ToString();

                this.objLeave.reason = collection["reason"].ToString();

                this.objLeave.other = collection["other"].ToString();

                return RedirectToAction();

            }catch(Exception ex)
            {
                return View();
            }
        }
    }
}
