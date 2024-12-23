using money.Dto;
using money.Dtos;

namespace money.Services
{
    public class UserService
    {
        public async Task<UserResponseDto> create(CreateUserDto createUserDto)
        {
            return new UserResponseDto()
            {
                Email = createUserDto.Email,
                Id = "id_hash_123",
                Name = createUserDto.Name,
            };
        }
    }
}
