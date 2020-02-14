using System.Web.Mvc;
using System.Collections.Generic;
using Employee.Data;
using Employee.Repository;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EmployeeRepository employeeRepository;
        public HomeController()
        {
            employeeRepository = new EmployeeRepository();
        }
        public ActionResult GetEmployees()
        {
            return View();
        }
        public ActionResult Index()
        {
            IEnumerable<Employees> employee = employeeRepository.GetAllEmployees();
            ViewData["employee"] = employee;
            ViewBag.employee = employee;
            TempData["employee"] = employee;
            //return RedirectToAction("GetEmployees");
            return View();
        }
    }
}