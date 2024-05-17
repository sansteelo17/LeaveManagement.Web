using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data;

public class Employee : IdentityUser
{
    private DateTime _dateOfBirth;
    private DateTime _dateJoined;

    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? TaxId { get; set; }

    public DateTime DateOfBirth
    {
        get => _dateOfBirth;
        set => _dateOfBirth = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    }

    public DateTime DateJoined
    {
        get => _dateJoined;
        set => _dateJoined = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    }
}