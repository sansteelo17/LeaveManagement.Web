namespace LeaveManagement.Web.Models;

public class EmployeeLeaveRequestVM
{
    public EmployeeLeaveRequestVM(List<LeaveAllocationVM> leaveAllocations, List<LeaveRequestVM> leaveRequests)
    {
        LeaveAllocations = leaveAllocations;
        LeaveRequests = leaveRequests;
    }

    public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    public List<LeaveRequestVM> LeaveRequests { get; set; }
}