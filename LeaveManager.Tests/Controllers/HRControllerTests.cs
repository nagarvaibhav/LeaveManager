using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeaveManager.Controllers;
using LeaveManager.Services;
using NSubstitute;

namespace LeaveManager.Tests.Controllers
{
    [TestClass]
    public class HRControllerTests
    {
        [TestMethod]
        public void Index()
        {
            var leaveServiceMock = Substitute.For<ILeaveService>();
            HRController controller = new HRController(leaveServiceMock);

            ViewResult result = controller.Index() as ViewResult;
            leaveServiceMock.ReceivedWithAnyArgs().GetAnnualLeavesByDepartment(null, Utility.Enums.Departments.HR);
            Assert.IsNotNull(result);
        }
    }
}
