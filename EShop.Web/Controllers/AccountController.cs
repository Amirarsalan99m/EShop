using EShop.Application.DTOs.Account;
using EShop.Application.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EShop.Web.Controllers
{
    public class AccountController : BaseApiController
    {
        private IUserService _userService;

        #region Constructor

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region Register

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO register)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest();

            var result = await _userService.RegisterUser(register);

            if (result == RegisterUserResult.EmailExists)
                return Ok(new {status = "emailExists"});

            return Ok(new { status="success", result=result });
        }

        #endregion

        #region Login

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDTO login)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest();


            var result = await _userService.LoginUser(login);

            switch (result)
            {
                case LoginUserResult.IncorrectUsernameOrPassword:
                    return Ok(new {status = "incorrectUsernameOrPassword"});
                    
                    case LoginUserResult.NotActivated:
                    return Ok(new {status = "notActivated"});

                case LoginUserResult.Success:
                    string secretKey = Environment.GetEnvironmentVariable("JWT_SECRET_KEY");
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
                    var user = await _userService.GetUserByEmail(login.Email);
                    var signinCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var tokenOptions = new JwtSecurityToken(
                        issuer: "https://localhost:5001/",
                        claims: new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, user.Email),
                            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
                        },
                        expires: DateTime.Now.AddDays(30),
                        signingCredentials: signinCredentials
                        );

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                    return Ok(new {status = "success", token = tokenString, expireTime = 30, userFirstName = user.FirstName, userLastName = user.LastName, userId = user.Id });
            }

            return Ok(new {status = "somethingWentWrong"});
        }

        #endregion

        #region Logout

        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync();
                return Ok();
            }

            return BadRequest();
        }

        #endregion
    }
}
