namespace LeaveManagement.Web.Data;

public abstract class BaseEntity
{
    private DateTime _dateCreated;
    private DateTime _dateModified;

    public int Id { get; set; }

    public DateTime DateCreated
    {
        get => _dateCreated;
        set => _dateCreated = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    }

    public DateTime DateModified
    {
        get => _dateModified;
        set => _dateModified = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    }
}