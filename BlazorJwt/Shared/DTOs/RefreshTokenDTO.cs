using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorJwt.Shared.DTOs
{
    public class RefreshTokenDTO
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
