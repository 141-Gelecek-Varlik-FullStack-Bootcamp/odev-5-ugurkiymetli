﻿using AutoMapper;
using Emerce_Model;
using Emerce_Service.User;
using Microsoft.AspNetCore.Mvc;

namespace Emerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;
        public UserController( IUserService _userService, IMapper _mapper )
        {
            userService = _userService;
            mapper = _mapper;
        }


        //Insert User returns General Object with IsSuccess, ErrorList, Posted Data...
        [HttpPost]
        [Route("register")]
        public General<Emerce_Model.User.UserViewModel> Insert( [FromBody] Emerce_Model.User.UserViewModel newUser )
        {
            return userService.Insert(newUser);
        }
        [HttpPost]
        [Route("login")]
        //public bool Login( [FromBody] string username, string password )
        //{

        //    return userService.Login(username, password);
        //}
        public General<Emerce_Model.User.UserLoginModel> Login( [FromBody] Emerce_Model.User.UserLoginModel user )
        {
            return userService.Login(user);
        }
    }
}