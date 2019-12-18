using System;

namespace Ant.Permissions.API.Model
{
    /// <summary>
    /// 基础
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        public Guid TenantId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdatedTime { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}