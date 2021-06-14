using BilgeadamEgitim.Common.DTO;
using BilgeadamEgitim.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BilgeadamEgitim.Core.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<LoginResponseDTO> Authenticate(string username, string password);
        Task<User> UserRegister(User newUser);

    }
}
