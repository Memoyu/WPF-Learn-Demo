﻿using Microsoft.AspNetCore.Mvc;
using ToDo.Api.Context;
using ToDo.Api.Service;
using ToDo.Shared.Dtos;
using ToDo.Shared.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Api.Controllers
{
    /// <summary>
    /// 账户控制器
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService service;

        public LoginController(ILoginService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ApiResponse> Login(string account, string passWord) =>
            await service.LoginAsync(account, passWord);

        [HttpPost]
        public async Task<ApiResponse> Resgiter([FromBody] UserDto param) =>
            await service.Resgiter(param);

    }
}
