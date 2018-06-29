using LeaveManager.DTO;
using LeaveManager.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeaveManager.Tests.Rules
{
    public class AccountsLeaveRulesTests
    {
        [TestMethod]
        public void GetAnnualLeaves_Should_Calculate_Leaves_For_PassedParams()
        {
            var leaveParamsDTO = new LeaveParamsDTO
            {
                CompOffs = 5,
                PersonalLeaves = 4,
                SickLeaves = 3
            };

            var rules = new AccountsLeaveRules();
            Assert.AreEqual(rules.GetAnnualLeaves(leaveParamsDTO), 12);
        }
    }
}
