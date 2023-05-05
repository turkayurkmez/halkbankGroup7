using eshop.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpPost]
        public IActionResult Login(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = userService.ValidateUser(model.UserName, model.Password);
                if (user != null)
                {
                    Claim[] claims =
                    {
                        new Claim(JwtRegisteredClaimNames.UniqueName,user.UserName),
                        new Claim(JwtRegisteredClaimNames.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Role),
                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Bu cümle çok önemli"));
                    var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        issuer: "api.halkbank.com",
                        audience: "krediler.halkbank.com",
                        claims: claims,
                        notBefore: DateTime.Now,
                        expires: DateTime.Now.AddDays(1),
                        signingCredentials: credential);

                    return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });

                }

                ModelState.AddModelError("login", "Kullanıcı adı ya da şifre hatalı");
            }

            return BadRequest(ModelState);
        }
    }
}
