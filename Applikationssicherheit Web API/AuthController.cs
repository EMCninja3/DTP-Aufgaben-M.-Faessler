using Microsoft.AspNetCore.Mvc;

namespace Applikationssicherheit_Web_API
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        public static User user = new User(); // in prod. in DB speichern        [HttpPost("register")]        public async Task<ActionResult<User>> Register(UserDto request) {            CreatePasswordHash(request.Password, out byte[] passwordhash, out byte[] passwordSalt);            user.Username = request.Username;            user.PasswordHash= passwordhash;            user.PasswordSalt = passwordSalt;            return Ok(user);        }        private static void CreatePasswordHash(string plainPassword, out byte[] passwordHash, out byte[] passwordSalt) {            using (var hmac = new HMACSHA256()) {                passwordSalt = hmac.Key;                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));            }        }    }

    }

