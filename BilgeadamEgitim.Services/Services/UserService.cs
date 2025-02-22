﻿using BilgeadamEgitim.Common.DTO;
using BilgeadamEgitim.Core.Models;
using BilgeadamEgitim.Core.Services;
using BilgeadamEgitim.Core.UOW;
using BilgeadamEgitim.Services.Helper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BilgeadamEgitim.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppSettings _appSettings;

        public UserService(IUnitOfWork unitOfWork, IOptions<AppSettings> appSettings)
        {
            this._unitOfWork = unitOfWork;
            this._appSettings = appSettings.Value;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var users = await _unitOfWork.Users.GetAllAsync();

            return users;
        }

        public async Task<LoginResponseDTO> Authenticate(string username,string password)
        {
            var user = await _unitOfWork.Users.SingleOrDefaultAsync(x=> x.Username == username && x.Password == password);
            
            if (user == null)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes., user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenstring = tokenHandler.WriteToken(token);

            var loginResponse = new LoginResponseDTO
            {
                AccessToken = tokenstring,
                Email = user.Email,
                Name = user.Name,
                Username = user.Username
            };


            return loginResponse;
        }

        public async Task<User> UserRegister(User newUser)
        {
            await _unitOfWork.Users.AddAsync(newUser);
            await _unitOfWork.CommitAsync();

            return newUser;
        }

    }
}
