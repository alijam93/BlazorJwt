using System.Collections.Generic;

namespace BlazorJwt.Shared.Results
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
