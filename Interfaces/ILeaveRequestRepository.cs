using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Interfaces;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
    Task<EmployeeLeaveRequestVM> GetMyLeaveDetails();
    Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
    Task<List<LeaveRequest>> GetAllAsync(string employeeId);
    Task ChangeApprovalStatus(int leaveRequestId, bool approved);
    Task CancelLeaveRequest(int leaveRequestId);
    Task<AdminLeaveRequestVM> GetAdminLeaveRequestList();
}