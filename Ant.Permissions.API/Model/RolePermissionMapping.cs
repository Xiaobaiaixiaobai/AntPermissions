using System;

namespace Ant.Permissions.API.Model
{
    /// <summary>
    /// 角色权限映射表
    /// </summary>
    public class RolePermissionMapping : BaseEntity
    {
        /// <summary>
        /// 角色Id
        /// </summary>
        public Guid RoleId { get; set; }

        public Role Role { get; set; }

        /// <summary>
        /// 权限Id
        /// </summary>
        public Guid PermissionId { get; set; }

        public Permission Permission { get; set; }
    }
}