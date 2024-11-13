using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp.Core.Entities
{
  public class UserOperationClaim : IEntity
  {
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid OperationClaimId { get; set; }
    public DateTime AddedTime { get; set; }
    public bool IsActive { get; set; }
    //public int CompanyId { get; set; }  ❗
  }
}
