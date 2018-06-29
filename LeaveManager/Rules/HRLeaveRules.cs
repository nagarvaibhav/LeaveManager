using LeaveManager.DTO;
using static LeaveManager.Utility.Enums;

namespace LeaveManager.Rules
{
    public class HRLeaveRules : ILeaveRules
    {
        public Departments Department
        {
            get
            {
                return Departments.HR;
            }
        }

        public int GetAnnualLeaves(LeaveParamsDTO leaveParams)
        {
            return leaveParams.PersonalLeaves + leaveParams.SickLeaves;
        }
    }
}