using LeaveManager.DTO;
using LeaveManager.Rules;
using LeaveManager.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeaveManager.Tests.Services
{
    [TestFixture]
    public class LeaveServiceTests
    {
        private List<ILeaveRules> _rules;
        private LeaveService _leaveService;

        [SetUp]
        public void SetUp()
        {
            _rules = new List<ILeaveRules>();
            _rules.Add(new HRLeaveRules());
            _rules.Add(new AccountsLeaveRules());
            _leaveService = new LeaveService(_rules);
        }

        [Test]
        public void GetAnnualLeavesByDepartment_Should_Return_Leaves_For_ProperDepartment()
        {
            var leaveParamsDTO = new LeaveParamsDTO
            {
                CompOffs = 5,
                PersonalLeaves = 4,
                SickLeaves = 3
            };

            Assert.AreEqual(_leaveService.GetAnnualLeavesByDepartment(leaveParamsDTO, Utility.Enums.Departments.Accounts), 12);

            Assert.AreEqual(_leaveService.GetAnnualLeavesByDepartment(leaveParamsDTO, Utility.Enums.Departments.HR), 7);
        }

        [Test]
        public void GetAnnualLeavesByDepartment_Should_Throw_Exception_For_Empty_Dependencies()
        {
            _rules.Clear();
            var leaveParamsDTO = new LeaveParamsDTO
            {
                CompOffs = 5,
                PersonalLeaves = 4,
                SickLeaves = 3
            };

            Assert.Throws<InvalidOperationException>(() => _leaveService.GetAnnualLeavesByDepartment(leaveParamsDTO, Utility.Enums.Departments.HR));
        }
    }
}
