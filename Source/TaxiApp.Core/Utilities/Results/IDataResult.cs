using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp.Core.Utilities.Results
{
  public interface IDataResult<out TEntity> : IResult
  {
    TEntity Data { get; }
  }
}
