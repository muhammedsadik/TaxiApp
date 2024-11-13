using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Core.Entities;
using TaxiApp.Core.Extensions;
using TaxiApp.Core.Utilities.Security.Encyption;

namespace TaxiApp.Core.Utilities.Security.Jwt
{
  public class JwtHelper : ITokenHelper
  {
    public IConfiguration Configuration { get; } // appsettings teki bilgileri bunun aracılığıyla okuyacaz
    private TokenOptions _tokenOptions;
    DateTime _accessTokenExpiration;

    public JwtHelper(IConfiguration configuration)
    {
      Configuration = configuration;
      _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
    }

    public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
    {
      _accessTokenExpiration = DateTime.Now.AddDays(_tokenOptions.AccessTokenExpiration);

      var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);

      var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);//securityKey ve algoritmamızı belirlediğimiz bir nesnedir.

      var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);

      var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

      var token = jwtSecurityTokenHandler.WriteToken(jwt);

      return new AccessToken
      {
        Token = token,
        Expiration = _accessTokenExpiration
      };
    }

    public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user, SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
    {
      var jwt =new JwtSecurityToken
      (
        issuer: tokenOptions.Issuer,
        audience: tokenOptions.Audience,
        expires: _accessTokenExpiration,
        notBefore: DateTime.Now,
        claims: SetClaims(user, operationClaims),
        signingCredentials: signingCredentials
      );

      return jwt;
    }


    private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
    {
      var claims = new List<Claim>();

      claims.AddNameIdentifier(user.Id.ToString());
      claims.AddEmail(user.Email);
      claims.AddName($"{user.UserName} {user.Surname}");
      claims.AddRoles(operationClaims.Select(c => c.OperationClaimName).ToArray());
      return claims;
    }

  }
}
