using Microsoft.AspNetCore.Mvc;

namespace money.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        [HttpGet(Name = "userById")]
        public bool userById(int id)
        {
            return true;
        }
    }
}
