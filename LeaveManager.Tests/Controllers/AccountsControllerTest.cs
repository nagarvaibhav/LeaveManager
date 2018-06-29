using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeaveManager.Controllers;
using LeaveManager.Services;
using NSubstitute;

namespace LeaveManager.Tests.Controllers
{
    [TestClass]
    public class AccountsControllerTest
    {
        [TestMethod]
        public void Index()
        {
            var leaveServiceMock = Substitute.For<ILeaveService>();
            AccountsController controller = new AccountsController(leaveServiceMock);

            ViewResult result = controller.Index() as ViewResult;
            leaveServiceMock.ReceivedWithAnyArgs().GetAnnualLeavesByDepartment(null, Utility.Enums.Departments.Accounts);
            Assert.IsNotNull(result);
        }
    }
}
