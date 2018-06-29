using LeaveManager.DTO;
using LeaveManager.Models;
using LeaveManager.Services;
using System.Web.Mvc;

namespace LeaveManager.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ILeaveService _leaveService;
        public AccountsController(ILeaveService leaveService)
        {
            _leaveService = leaveService;
        }

        // GET: Accounts
        public ActionResult Index()
        {
            var leaveParams = new LeaveParamsDTO
            {
                CompOffs = 5,
                PersonalLeaves = 20,
                SickLeaves = 10
            };
            var result = _leaveService.GetAnnualLeavesByDepartment(leaveParams, Utility.Enums.Departments.Accounts);
            var model = new LeaveModel() { AnnualLeaves = result };
            return View(model);
        }
    }
}