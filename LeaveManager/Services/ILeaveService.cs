using LeaveManager.DTO;
using static LeaveManager.Utility.Enums;

namespace LeaveManager.Services
{
    public interface ILeaveService
    {
        int GetAnnualLeavesByDepartment(LeaveParamsDTO leaveParams, Departments department);
    }
}
