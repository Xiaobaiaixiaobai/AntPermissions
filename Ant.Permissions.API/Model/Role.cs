namespace Ant.Permissions.API.Model
{
    /// <summary>
    /// 角色信息
    /// </summary>
    public class Role : BaseEntity
    {
        /// <summary>
        /// 角色名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public int OrderSort { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}