using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities;

public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "771b552d-5792-40b6-afc4-83fbbgd383f7",
                UserId = "f059abae-4be1-42ca-8c74-40d702aebac4"
            },
             new IdentityUserRole<string>
             {
                 RoleId = "999c552d-5812-40d6-afc4-83feegd383f9",
                 UserId = "771b467d-5362-40b6-afc4-83f339d383f7"
             }
        );
    }
}