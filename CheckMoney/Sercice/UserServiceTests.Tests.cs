
namespace Money.Services
{
    using Microsoft.EntityFrameworkCore;
    using Money.Data;
    using Money.DTOs;
    using Money.Models;
    using Xunit;

    public class UserServiceTests
    {
        [Fact]
        public async Task ShouldThrowExceptionWhenEmailAlreadyInUse()
        {
            var options = new DbContextOptionsBuilder<MoneyDbContext>().UseInMemoryDatabase("true").Options as Microsoft.Extensions.Configuration.IConfiguration;
            if (options is not null)
            {
            using (var moneyDb = new MoneyDbContext(options))
            {
                    moneyDb.Add(new User()
                    {
                        Name = "Nícolas Krüger",
                        Email = "nicolas@email.com"
                    });
                    moneyDb.SaveChanges();
                    var userService = new UserService(moneyDb);
                    var createUserDTO = new CreateUserDTO()
                    {
                        Name = "Nícolas Krüger",
                        Email = "nicolas@email.com",
                        Password = "password1",
                    };
                await Assert.ThrowsAsync<Exception>(() => userService.Create(createUserDTO));
            }
            }

        }
    }
}
