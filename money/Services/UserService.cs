using BCrypt.Net;
using money.Data;
using money.Dto;
using money.Dtos;
using money.Models;

namespace money.Services
{
    public class UserService
    {
        private readonly MoneyDbContext _moneyDb;
        public UserService(MoneyDbContext moneyDb) { _moneyDb = moneyDb; }
        public async Task<UserResponseDto> create(CreateUserDto createUserDto)
        {
            var has = _moneyDb.Users.Where(user => user.Email == createUserDto.Email).Count();

            if(has > 0)
            {
                throw new Exception("Email already in use");
            }

            var user = _moneyDb.Users.Add(new User()
            {
                Name = createUserDto.Name,
                Email = createUserDto.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(createUserDto.Password),
            });
            await _moneyDb.SaveChangesAsync();
            

            return new UserResponseDto()
            {
                Id = user.Entity.Id,
                Name = user.Entity.Name,
                Email = user.Entity.Email,
            };
        }
    }
}
