using LeaveManager.DTO;
using static LeaveManager.Utility.Enums;

namespace LeaveManager.Rules
{
    public interface ILeaveRules
    {
        Departments Department { get;}
        int GetAnnualLeaves(LeaveParamsDTO leaveParams);
    }
}
