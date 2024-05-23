using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Interfaces;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories;

public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<Employee> _userManager;
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public LeaveAllocationRepository(
        ApplicationDbContext context,
        UserManager<Employee> userManager,
        ILeaveTypeRepository leaveTypeRepository,
        IMapper mapper) : base(context)
    {
        _context = context;
        _userManager = userManager;
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }

    public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
    {
        return await _context.LeaveAllocations.AnyAsync(
            allocation => allocation.EmployeeId == employeeId &&
            allocation.LeaveTypeId == leaveTypeId &&
            allocation.Period == period);
    }

    public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
    {
        var allocations = await _context.LeaveAllocations.Include(
            allocation => allocation.LeaveType).Where(
            a => a.EmployeeId == employeeId).ToListAsync();
        var employee = await _userManager.FindByIdAsync(employeeId);

        var employeeAllocationModel = _mapper.Map<EmployeeAllocationVM>(employee);
        employeeAllocationModel.LeaveAllocations = _mapper.Map<List<LeaveAllocationVM>>(allocations);

        return employeeAllocationModel;
    }

    public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id)
    {
        var allocation = await _context.LeaveAllocations.Include(
            allocation => allocation.LeaveType).FirstOrDefaultAsync(
            a => a.Id == id);

        if (allocation == null) return null;

        var employee = await _userManager.FindByIdAsync(allocation.EmployeeId);

        var model = _mapper.Map<LeaveAllocationEditVM>(allocation);
        model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(allocation.EmployeeId));

        return model;
    }

    public async Task LeaveAllocation(int leaveTypeId)
    {
        var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
        var period = DateTime.Now.Year;
        var leaveType = await _leaveTypeRepository.GetAsync(leaveTypeId);
        var allocations = new List<LeaveAllocation>();

        foreach (var employee in employees)
        {
            if (await AllocationExists(employee.Id, leaveTypeId, period)) continue;

            allocations.Add(new LeaveAllocation
            {
                EmployeeId = employee.Id,
                LeaveTypeId = leaveTypeId,
                Period = period,
                NumberOfDays = leaveType.DefaultDays
            });
        }

        await AddRangeAsync(allocations);
    }

    public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
    {
        var leaveAllocation = await GetAsync(model.Id);

        if (leaveAllocation == null)
        {
            return false;
        }

        leaveAllocation.Period = model.Period;
        leaveAllocation.NumberOfDays = model.NumberOfDays;

        await UpdateAsync(leaveAllocation);
        return true;
    }

    public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId)
    {
        return await _context.LeaveAllocations.FirstOrDefaultAsync(
            allocation => allocation.EmployeeId == employeeId && allocation.LeaveTypeId == leaveTypeId);
    }
}