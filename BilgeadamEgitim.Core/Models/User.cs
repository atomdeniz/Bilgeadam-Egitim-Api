using BilgeadamEgitim.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeadamEgitim.Core.Models
{
    public class User : BaseEntity
    {
        /// <summary>
        /// Kullanıcı isimleri tutulur
        /// </summary>
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
