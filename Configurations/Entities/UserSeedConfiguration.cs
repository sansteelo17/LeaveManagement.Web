using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities;

public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        var hasher = new PasswordHasher<Employee>();
        builder.HasData(
            new Employee
            {
                Id = "f059abae-4be1-42ca-8c74-40d702aebac4",
                Email = "admin@leavemgt.com",
                NormalizedEmail = "ADMIN@LEAVEMGT.COM",
                UserName = "admin@leavemgt.com",
                NormalizedUserName = "ADMIN@LEAVEMGT.COM",
                Firstname = "System",
                Lastname = "Admin",
                PasswordHash = hasher.HashPassword(null, "Peshtes1!"),
                EmailConfirmed = true
            },
             new Employee
             {
                 Id = "771b467d-5362-40b6-afc4-83f339d383f7",
                 Email = "peshtaco@gmail.com",
                 NormalizedEmail = "PESHTACO@GMAIL.COM",
                 UserName = "peshtaco@gmail.com",
                 NormalizedUserName = "PESHTACO@GMAIL.COM",
                 Firstname = "System",
                 Lastname = "User",
                 PasswordHash = hasher.HashPassword(null, "Peshtes1!"),
                 EmailConfirmed = true
             }
        );
    }
}