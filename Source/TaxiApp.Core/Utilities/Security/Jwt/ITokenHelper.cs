using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Core.Entities;

namespace TaxiApp.Core.Utilities.Security.Jwt
{
  public interface ITokenHelper
  {
    AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
  }
}
