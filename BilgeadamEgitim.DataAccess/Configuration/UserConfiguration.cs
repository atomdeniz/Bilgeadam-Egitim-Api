using BilgeadamEgitim.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeadamEgitim.DataAccess.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(

                new User
                {
                    Id = 1,
                    Name = "Deniz",
                    Surname = "Ozogul",
                    Username = "atomdeniz",
                    Password = "12345",
                    Email = "deneme@gmail.com",

                },
                new User
                {
                    Id = 2,
                    Name = "Mehmet",
                    Surname = "Ahmet",
                    Username = "mehmetahmet",
                    Password = "123456",
                    Email = "deneme2@gmail.com",

                }
           );
        }

    }
}
