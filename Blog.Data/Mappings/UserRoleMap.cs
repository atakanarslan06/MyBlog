using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    internal class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("48E58468-8A50-46AD-AC18-04EC33FA1818"),
                RoleId = Guid.Parse("620938A5-EF18-421C-8F72-65291F44C678"),
            },
            new AppUserRole
            {
                UserId = Guid.Parse("5C4C8997-E65F-46C2-B823-6B882CF151A3"),
                RoleId = Guid.Parse("10BAEB44-0BAD-477E-8D5F-0437AEF0EBDB"),
            }
            );
        }
    }
}
