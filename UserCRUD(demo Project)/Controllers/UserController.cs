using Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserCRUD_demo_Project_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }

        //get all users
        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            return Ok( _user.GetAllUsers());
        }

        //get one user
        [HttpGet]
        [Route("get")]
        public IActionResult GetUser(int Id)
        {
            return Ok(_user.GetUserByID(Id));
        }

        //[HttpGet]
        //[Route("get1")]
        //public IActionResult GetUser1(int Id)
        //{
        //    return Ok(_user.GetUserByID(Id));
        //}

        //add user
        [HttpPost("add")]
        public IActionResult AddUser(User user)
        {
            return Ok( _user.AddUser(user));
        }
        //remove user
        [HttpDelete]
        public IActionResult RemoveUser(int Id)
        {
            return Ok(_user.RemoveUser(Id));
        }
        //update user
        [HttpPut("update")]
        public IActionResult UpdateUser(User user)
        {
            return Ok( _user.UpdateUser(user));
        }

    }
}
