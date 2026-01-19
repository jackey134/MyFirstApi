using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Models;

namespace MyFirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // 任務 1：建立一個變數（你等等要填）
        private string myName = "Jackey";


        [HttpGet("old")]
        public IActionResult GetOld()
        {
            var user = new
            {
                Name = "小明",
                Age = 20,
            };
            return Ok(user);
        }

        [HttpGet("new")]
        public IActionResult GetNew()
        {
            var user = new User
            {
                Id = 1,
                Name = "小華",
                Email = "xiaohua@example.com",
                Age = 22,
                IsActive = true,
                CreatedAt = DateTime.Now
            };
            return Ok(user);
        }

        [HttpGet("list")]
        public IActionResult GetList()
        {
            var users = new List<User>
            {
                new User { Id = 1, Name = "小明", Email = "ming@example.com", Age = 25, IsActive = true, CreatedAt = DateTime.Now },
                new User { Id = 2, Name = "小華", Email = "hua@example.com", Age = 30, IsActive = true, CreatedAt = DateTime.Now },
                new User { Id = 3, Name = "小美", Email = "mei@example.com", Age = 28, IsActive = false, CreatedAt = DateTime.Now }
            };
            return Ok(users);
        }


        // 任務 2：建立一個方法（你等等要填）
        [HttpGet]
        public UserInfo GetMyInfo()
        {
            var myInfo = new UserInfo
            {
                Name = myName,
                Age = 25,
                Job = "Software Developer",
                IsStudent = false,
            };

            return myInfo;
        }

        [HttpPost("v2")]
        public IActionResult Create([FromBody] User user)
        {
            return Ok(new { Message = $"成功建立使用者：{user.Name}" });
        }

        [HttpGet("greet/{myName}")]
        public string Greet(string myName)
        {
            return $"hello,{myName} welcome to my API!";
        }


        [HttpPost("v1")]
        public string CreateUser([FromBody] UserInfo newUser)
        {
            return $"User {newUser.Name} created successfully!";
        }

    }
}