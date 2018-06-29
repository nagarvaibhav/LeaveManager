using LeaveManager.DTO;
using LeaveManager.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeaveManager.Tests.Rules
{
    [TestClass]
    public class HRLeaveRulesTests
    {
        [TestMethod]
        public void GetAnnualLeaves_Should_Calculate_Leaves_For_PassedParams()
        {
            var leaveParamsDTO = new LeaveParamsDTO
            {
                PersonalLeaves = 4,
                SickLeaves = 3
            };

            var rules = new HRLeaveRules();
            Assert.AreEqual(rules.GetAnnualLeaves(leaveParamsDTO), 7);
        }

        [TestMethod]
        public void GetAnnualLeaves_Should_Calculate_Leaves_For_PassedParams_AND_IgnoreOtherParams()
        {
            var leaveParamsDTO = new LeaveParamsDTO
            {
                CompOffs = 5,
                PersonalLeaves = 4,
                SickLeaves = 4
            };

            var rules = new HRLeaveRules();
            Assert.AreEqual(rules.GetAnnualLeaves(leaveParamsDTO), 8);
        }
    }
}
