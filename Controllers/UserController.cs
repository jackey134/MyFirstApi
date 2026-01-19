using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // 任務 1：建立一個變數（你等等要填）
        private string myName = "Jackey";


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

        [HttpGet("greet/{myName}")]
        public string Greet(string myName)
        {
            return $"hello,{myName} welcome to my API!";
        }


        [HttpPost]
        public string CreateUser([FromBody] UserInfo newUser)
        {
            return $"User {newUser.Name} created successfully!";
        }

    }
}