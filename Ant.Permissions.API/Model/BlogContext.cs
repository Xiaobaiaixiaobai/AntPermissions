using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ant.Permissions.API.Model
{
    public class BlogContext: DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<ApiModule> ApiModule { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RolePermissionMapping> RolePermissionMapping { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRoleMapping> UserRoleMapping { get; set; }

    }
}
