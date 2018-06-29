using LeaveManager.DTO;
using LeaveManager.Rules;
using System.Collections.Generic;
using System.Linq;
using static LeaveManager.Utility.Enums;

namespace LeaveManager.Services
{
    public class LeaveService : ILeaveService
    {
        private readonly IEnumerable<ILeaveRules> _rules;
        public LeaveService(IEnumerable<ILeaveRules> rules)
        {
            _rules = rules;
        }

        public int GetAnnualLeavesByDepartment(LeaveParamsDTO leaveParams, Departments department)
        {
            var departmentLeaveRule = _rules.First(x => x.Department.Equals(department));
            if (departmentLeaveRule != null)
                return departmentLeaveRule.GetAnnualLeaves(leaveParams);

            return 0;
        }
    }
}