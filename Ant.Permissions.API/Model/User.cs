namespace Ant.Permissions.API.Model
{
    /// <summary>
    /// 系统用户
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 性别 0男，1女，2保密
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string HeadImg { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        public string Token { get; set; }
        public string RoleId { get; set; }
    }
}