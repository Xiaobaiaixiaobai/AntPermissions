using System;

namespace Ant.Permissions.API.Model
{
    /// <summary>
    /// 权限表
    /// </summary>
    public class Permission : BaseEntity
    {
        /// <summary>
        /// 权限名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 操作码
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// 菜单Id
        /// </summary>
        public Guid MenuId { get; set; }

        public Menu Menu { get; set; }

        /// <summary>
        /// 权限类型
        /// </summary>
        public PermissionTypeEnum PermissionType { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 对应的API信息
        /// </summary>
        public Guid ApiModuleId { get; set; }

        public ApiModule ApiModule { get; set; }
    }

    /// <summary>
    /// 权限类型
    /// </summary>
    public enum PermissionTypeEnum
    {
        /// <summary>
        /// 菜单
        /// </summary>
        Menu = 0,

        /// <summary>
        /// 动作（按钮、操作、功能）
        /// </summary>
        Action = 1
    }
}