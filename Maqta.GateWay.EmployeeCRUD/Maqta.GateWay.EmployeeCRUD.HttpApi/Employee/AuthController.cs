using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private IConfiguration _iAppSettingConfiguration;

    public AuthController(IConfiguration iAppSettingConfiguration)
    {
        _iAppSettingConfiguration = iAppSettingConfiguration;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel user)
    {
        if (user is null)
        {
            return BadRequest("Invalid client request");
        }

        var tt = _iAppSettingConfiguration["Password"];
        var t = _iAppSettingConfiguration["User"];
        if (user.UserName == _iAppSettingConfiguration["User"] && user.Password == _iAppSettingConfiguration["Password"])
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_iAppSettingConfiguration["SecretKey"]));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokeOptions = new JwtSecurityToken(
                claims: new List<Claim>(),
                expires: DateTime.Now.AddMinutes(20),
                signingCredentials: signinCredentials
            );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return Ok(new AuthenticatedResponse { Token = tokenString });
        }
        return Unauthorized();
    }
}

public class LoginModel
{
    public string? UserName { get; set; }
    public string? Password { get; set; }
}

public class AuthenticatedResponse
{
    public string? Token { get; set; }
}