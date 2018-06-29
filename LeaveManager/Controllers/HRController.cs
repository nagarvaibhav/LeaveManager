using LeaveManager.DTO;
using LeaveManager.Models;
using LeaveManager.Services;
using System.Web.Mvc;

namespace LeaveManager.Controllers
{
    public class HRController : Controller
    {
        private readonly ILeaveService _leaveService;
        public HRController(ILeaveService leaveService)
        {
            _leaveService = leaveService;
        }

        public ActionResult Index()
        {
            var leaveParams = new LeaveParamsDTO
            {
                PersonalLeaves = 15,
                SickLeaves = 11
            };
            var result = _leaveService.GetAnnualLeavesByDepartment(leaveParams, Utility.Enums.Departments.HR);
            var model = new LeaveModel() { AnnualLeaves = result };

            return View(model);
        }
    }
}