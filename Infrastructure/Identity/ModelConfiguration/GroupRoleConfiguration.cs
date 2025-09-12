using Domain.Constants;
using Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Identity.ModelConfiguration
{
    public class GroupRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData(
                new ApplicationRole
                {
                    Id = RoleConstants.AdminRoleId, // static GUID to escape migration regeneration issues
                    Name = RoleConstants.Admin,
                    NormalizedName = RoleConstants.Admin.ToUpper()
                },
                new ApplicationRole
                {
                    Id = RoleConstants.UserRoleId, // static GUID to escape migration regeneration issues
                    Name = RoleConstants.User,
                    NormalizedName = RoleConstants.User.ToUpper()
                }
            );
        }
    }
}
