using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp.Core.Entities
{
  public class OperationClaim : IEntity // Kullanıcının rolleri (OperationClaim).
  {
    public Guid Id { get; set; }
    public string OperationClaimName { get; set; }
    public DateTime AddedTime { get; set; }
    public bool IsActive { get; set; }
  }
}
