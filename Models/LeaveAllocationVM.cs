using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models;

public class LeaveAllocationVM
{
    [Required]
    public int Id { get; set; }

    [Display(Name = "Number of Days")]
    [Required]
    [Range(1, 50, ErrorMessage = "Invalid number entered")]
    public int NumberOfDays { get; set; }

    [Required]
    [Display(Name = "Allocation Period")]
    public int Period { get; set; }

    public LeaveTypeVM? LeaveType { get; set; }
}