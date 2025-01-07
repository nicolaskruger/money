// <copyright file="UserService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Money.Services
{
    using BCrypt.Net;
    using Money.Data;
    using Money.DTOs;
    using Money.Models;

    public class UserService
    {
        private readonly MoneyDbContext moneyDb;

        public UserService(MoneyDbContext moneyDb) => this.moneyDb = moneyDb;

        public async Task<UserResponseDTO> Create(CreateUserDTO createUserDTO)
        {
            var has = this.moneyDb.Users.Where(user => user.Email == createUserDTO.Email).Count();

            if (has > 0)
            {
                throw new Exception("Email already in use");
            }

            var user = this.moneyDb.Users.Add(new User()
            {
                Name = createUserDTO.Name,
                Email = createUserDTO.Email,
                Password = BCrypt.HashPassword(createUserDTO.Password),
            });
            await this.moneyDb.SaveChangesAsync();
            return new UserResponseDTO()
            {
                Id = user.Entity.Id,
                Name = user.Entity.Name,
                Email = user.Entity.Email,
            };
        }
    }
}
