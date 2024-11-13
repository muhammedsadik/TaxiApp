using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Core.Entities;
using TaxiApp.EntityFrameworkCore.Concrete.GenericRepository;

namespace TaxiApp.Domain.Entities.Users
{
  public interface IUserRepositoy : IRepository<User>
  {
    //Task<IList<OperationClaim>> GetUserClaim(Guid userId);
  }
}
 