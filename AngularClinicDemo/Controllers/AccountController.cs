using AngularClinicDemo.Models;
using AngularClinicDemo.servicies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AngularClinicDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService;
        private readonly IConfiguration config;

        public AccountController(IAccountService _accountService, IConfiguration _config)
        {
            accountService = _accountService;
            config = _config;
        }

        [HttpPost]
        [Route("SignUp")]
        public async Task<IActionResult> SignUp(SignupModel signup)
        {
            var result = await accountService.CreateAccount(signup);
            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                return StatusCode(500,result.Errors);
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(SignInModel signin)
        {
            var result = await accountService.SignIn(signin);

            if (result.Succeeded)
            {
                
                var authClaim = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, signin.Email),
                    new Claim("UniqueValue", Guid.NewGuid().ToString())
                };

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:Secret"]));

                var token = new JwtSecurityToken(
                            issuer: config["JWT:ValidIssuer"],
                            audience: config["JWT:ValidAudience"],
                            expires: DateTime.Now.AddDays(15),
                            claims: authClaim,
                            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                            );

                return Ok(
                        new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token)
                        });

            }
            else
            { 
            }
            return Unauthorized();
         }
    }
}
