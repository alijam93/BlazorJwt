using BlazorJwt.Shared.DTOs;
using BlazorJwt.Shared.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorJwt.Client.Services.Interface
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginDTO loginModel);
        Task<RegisterResult> Register(RegisterDTO registerModel);
        Task Logout();
        Task<string> RefreshToken();
    }
}
