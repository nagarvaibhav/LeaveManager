using LeaveManager.DTO;
using static LeaveManager.Utility.Enums;

namespace LeaveManager.Rules
{
    public class AccountsLeaveRules : ILeaveRules
    {

        public Departments Department
        {
            get
            {
                return Departments.Accounts;
            }
        }

        public int GetAnnualLeaves(LeaveParamsDTO leaveParams)
        {
            return leaveParams.PersonalLeaves + leaveParams.SickLeaves + leaveParams.CompOffs;
        }
    }
}