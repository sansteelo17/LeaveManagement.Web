using LeaveManagement.Web.Data;
using LeaveManagement.Web.Interfaces;

namespace LeaveManagement.Web.Repositories;

public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
{
    public LeaveTypeRepository(ApplicationDbContext context) : base(context)
    {
    }
}