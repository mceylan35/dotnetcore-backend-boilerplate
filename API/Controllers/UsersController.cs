using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getAll")]
        public IActionResult GetList()
        {
            var result = _userService.GetList();
            if (result.Success)
            {
                return StatusCode(201, result);
            }
            else
            {
                return StatusCode(301, result);
            }
        }

        [HttpGet("getById")]
        public IActionResult GetById(Guid userId)
        {
            var result = _userService.GetById(userId);
            if (result.Success)
            {
                return StatusCode(201, result);
            }
            else
            {
                return StatusCode(301, result);
            }
        }
        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if (result.Success)
            {
                return StatusCode(201, result);
            }
            else
            {
                return StatusCode(301, result);
            }
        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return StatusCode(201, result);
            }
            else
            {
                return StatusCode(301, result);
            }
        }
        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            if (result.Success)
            {
                return StatusCode(201, result);
            }
            else
            {
                return StatusCode(301, result);
            }
        }


    }
}
