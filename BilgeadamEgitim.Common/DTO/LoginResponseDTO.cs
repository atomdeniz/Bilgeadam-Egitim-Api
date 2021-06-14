using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeadamEgitim.Common.DTO
{
    public class LoginResponseDTO
    {

        public LoginResponseDTO()
        {
            this.Roles = new List<string>();
        }
        public string AccessToken { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<string> Roles { get; set; }
    }
}
