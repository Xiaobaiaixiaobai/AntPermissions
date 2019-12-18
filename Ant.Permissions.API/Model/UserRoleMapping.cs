using System;

namespace Ant.Permissions.API.Model
{
    /// <summary>
    /// 用户角色映射表
    /// </summary>
    public class UserRoleMapping : BaseEntity
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public Guid UserId { get; set; }

        public User User { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        public Guid RoleId { get; set; }

        public Role Role { get; set; }
    }
}