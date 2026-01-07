using app_backend.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace app_backend.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetCurrentUserAsync();
        Task<UserDto> UpdateCurrentUserAsync(UserUpdateDto update);
    }
}
