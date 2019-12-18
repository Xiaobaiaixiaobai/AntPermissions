namespace Ant.Permissions.API.Model
{
    /// <summary>
    /// API相关信息
    /// </summary>
    public class ApiModule : BaseEntity
    {
        /// <summary>
        /// 接口名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 接口地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 接口描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// API请求方式
        /// </summary>
        public RequestMethodEnum RequestMethod { get; set; }
    }

    /// <summary>
    /// API请求方式
    /// </summary>
    public enum RequestMethodEnum
    {
        GET = 0,
        POST = 1,
        PUT = 2,
        DELETE = 3,
        OPTION = 4
    }
}