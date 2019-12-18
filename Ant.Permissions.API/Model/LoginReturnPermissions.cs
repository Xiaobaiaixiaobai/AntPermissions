using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ant.Permissions.API.Model
{

    public class userInfo 
    {
        private string  id;
        private string name;
        private string username;
        private string password;
        private string avatar;
        private int status;
        private string creatorId;
        private string createTime;
        private string merchantCode;
        private string roleId;
        private roleObj role;
        private int deleted;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public int Status { get => status; set => status = value; }
        public string CreatorId { get => creatorId; set => creatorId = value; }
        public string CreateTime { get => createTime; set => createTime = value; }
        public string MerchantCode { get => merchantCode; set => merchantCode = value; }
        public string RoleId { get => roleId; set => roleId = value; }
        public roleObj Role { get => role; set => role = value; }
        public int Deleted { get => deleted; set => deleted = value; }
    }
    public class roleObj
    {
        private string id;
        private string name;
        private string describe;
        private string status;
        private string creatorId;
        private string createTime;
        private string deleted;
        private List<permissions> permissions;
        public string Deleted { get => deleted; set => deleted = value; }
        public string CreateTime { get => createTime; set => createTime = value; }
        public string CreatorId { get => creatorId; set => creatorId = value; }
        public string Status { get => status; set => status = value; }
        public string Describe { get => describe; set => describe = value; }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public List<permissions> Permissions { get => permissions; set => permissions = value; }
    }
    public class permissions
    {
        private string roleId;
        private string permissionId;
        private string permissionName;
        private List<actions> actions;
        private List<actions> actionEntitySet;

        public List<actions> Actions { get => actions; set => actions = value; }
        public List<actions> ActionEntitySet { get => actionEntitySet; set => actionEntitySet = value; }
        public string PermissionName { get => permissionName; set => permissionName = value; }
        public string PermissionId { get => permissionId; set => permissionId = value; }
        public string RoleId { get => roleId; set => roleId = value; }
    }
    public class actions
    {
        private string action;
        private bool defaultCheck;
        private string describe;

        public string Action { get => action; set => action = value; }
        public string Describe { get => describe; set => describe = value; }
        public bool DefaultCheck { get => defaultCheck; set => defaultCheck = value; }
    }
}
