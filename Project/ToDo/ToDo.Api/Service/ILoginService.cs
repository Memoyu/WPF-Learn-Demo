﻿using ToDo.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Api.Service
{
    public interface ILoginService
    {
        Task<ApiResponse> LoginAsync(string Account, string Password);

        Task<ApiResponse> Resgiter(UserDto user);
    }
}
