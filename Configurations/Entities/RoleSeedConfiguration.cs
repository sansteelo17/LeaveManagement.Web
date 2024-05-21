using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configurations.Entities;

public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "771b552d-5792-40b6-afc4-83fbbgd383f7",
                Name = Roles.Administrator,
                NormalizedName = Roles.Administrator.ToUpper()
            },
            new IdentityRole
            {
                Id = "999c552d-5812-40d6-afc4-83feegd383f9",
                Name = Roles.User,
                NormalizedName = Roles.User.ToUpper()
            }
        );
    }
}