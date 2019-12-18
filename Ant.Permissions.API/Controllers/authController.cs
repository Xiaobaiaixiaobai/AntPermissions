using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Ant.Permissions.API.Model;
namespace Ant.Permissions.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class authController : Controller
    {
        [Route("Login")]
        [HttpPost]
        public IActionResult Login([FromForm]User user)
        {
            return Json(new
            {
                result = new User() { Token = "4291d7da9005377ec9aec4a71ea837f", RoleId = "admin" }
            });
        }
        [Route("Info")]
        [HttpGet]
        public IActionResult Info([FromForm]User user)
        {
            userInfo usinfo = new userInfo
            {
                Id = "4291d7da9005377ec9aec4a71ea837f",
                Name = "天野远子",
                Username= "admin",
                Password = "",
                Avatar = "/avatar2.jpg",
                Status = 1,
                CreatorId = "admin",
                CreateTime = "1497160610259",
                MerchantCode = "TLif2btpzg079h15bk",
                Deleted = 0,
                RoleId = "admin"
            };

            roleObj _roleObj = new roleObj
            {
                Id = "admin",
                Name = "管理员",
                Describe = "拥有所有权限",
                Status = "1",
                CreatorId = "system",
                CreateTime = "1497160610259",
                Deleted = "0"
            };
            permissions permissions = new permissions
            {
                RoleId = "admin",
                PermissionId = "dashboard",
                PermissionName = "仪表盘"
            };
            actions actions1 = new actions() { Action = "add", DefaultCheck = false, Describe = "新增" };
            actions actions2 = new actions() { Action = "query", DefaultCheck = false, Describe = "查询" };
            actions actions3 = new actions() { Action = "get", DefaultCheck = false, Describe = "详情" };
            actions actions4 = new actions() { Action = "update", DefaultCheck = false, Describe = "修改" };
            actions actions5 = new actions() { Action = "delete", DefaultCheck = false, Describe = "删除" };
            List<actions> actionslist = new List<actions>
            {
                actions1,
                actions2,
                actions3,
                actions4,
                actions5
            };
            permissions.Actions = actionslist;
            List<actions> actionEntitySetlist = new List<actions>
            {
                actions1,
                actions2,
                actions3,
                actions4,
                actions5
            };
            permissions.ActionEntitySet = actionEntitySetlist;
            _roleObj.Permissions = new List<permissions>{ permissions };
            usinfo.Role = _roleObj;
            return Json(new
            {
                result = usinfo
            });
        }
    }
}