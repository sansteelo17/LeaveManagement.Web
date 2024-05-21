using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Web.Data;
using AutoMapper;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Interfaces;
using Microsoft.AspNetCore.Authorization;
using LeaveManagement.Web.Constants;

namespace LeaveManagement.Web.Controllers;

[Authorize(Roles = Roles.Administrator)]
public class LeaveTypesController : Controller
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }

    // GET: LeaveTypes
    public async Task<IActionResult> Index()
    {
        var leaveTypes = _mapper.Map<List<LeaveTypeVM>>(await _leaveTypeRepository.GetAllAsync());
        return View(leaveTypes);
    }

    // GET: LeaveTypes/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        var leaveType = await _leaveTypeRepository.GetAsync(id);
        if (leaveType == null)
        {
            return NotFound();
        }
        var leaveTypeVM = _mapper.Map<LeaveTypeVM>(leaveType);
        return View(leaveTypeVM);
    }

    // GET: LeaveTypes/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: LeaveTypes/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
    {
        if (ModelState.IsValid)
        {
            var leaveType = _mapper.Map<LeaveType>(leaveTypeVM);
            await _leaveTypeRepository.AddAsync(leaveType);
            return RedirectToAction(nameof(Index));
        }
        return View(leaveTypeVM);
    }

    // GET: LeaveTypes/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        var leaveType = await _leaveTypeRepository.GetAsync(id);
        if (leaveType == null)
        {
            return NotFound();
        }

        var leaveTypeVM = _mapper.Map<LeaveTypeVM>(leaveType);
        return View(leaveTypeVM);
    }

    // POST: LeaveTypes/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
    {
        if (id != leaveTypeVM.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                var leaveType = _mapper.Map<LeaveType>(leaveTypeVM);
                await _leaveTypeRepository.UpdateAsync(leaveType);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _leaveTypeRepository.Exists(leaveTypeVM.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(leaveTypeVM);
    }

    // POST: LeaveTypes/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _leaveTypeRepository.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }
}
