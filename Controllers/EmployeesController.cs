using Microsoft.AspNetCore.Mvc;
using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using LeaveManagement.Web.Constants;
using AutoMapper;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Interfaces;

namespace LeaveManagement.Web.Controllers;
public class EmployeesController : Controller
{
    private readonly IMapper _mapper;
    private readonly UserManager<Employee> _userManger;
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public EmployeesController(
        UserManager<Employee> userManager,
        IMapper mapper,
        ILeaveAllocationRepository leaveAllocationRepository,
        ILeaveTypeRepository leaveTypeRepository)
    {
        _userManger = userManager;
        _mapper = mapper;
        _leaveAllocationRepository = leaveAllocationRepository;
        _leaveTypeRepository = leaveTypeRepository;
    }

    // GET: Employees
    public async Task<IActionResult> Index()
    {
        var employees = await _userManger.GetUsersInRoleAsync(Roles.User);
        var model = _mapper.Map<List<EmployeeListVM>>(employees);
        return View(model);
    }

    // GET: Employees/ViewAllocations/employeeId
    public async Task<IActionResult> ViewAllocations(string id)
    {
        var model = await _leaveAllocationRepository.GetEmployeeAllocations(id);
        return View(model);
    }

    // GET: Employees/EditAllocation/5
    public async Task<IActionResult> EditAllocation(int id)
    {
        var model = await _leaveAllocationRepository.GetEmployeeAllocation(id);
        if (model == null)
        {
            return NotFound();
        }

        return View(model);
    }

    // POST: Employees/EditAllocation/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
    {
        try
        {
            if (ModelState.IsValid)
            {
                if (await _leaveAllocationRepository.UpdateEmployeeAllocation(model))
                {
                    return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
                }
            }
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, "An error has occured. Please try again later.");
        }

        model.Employee = _mapper.Map<EmployeeListVM>(await _userManger.FindByIdAsync(model.EmployeeId));
        model.LeaveType = _mapper.Map<LeaveTypeVM>(await _leaveTypeRepository.GetAsync(model.LeaveTypeId));
        return View(model);
    }
}
