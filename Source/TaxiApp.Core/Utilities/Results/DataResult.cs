using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp.Core.Utilities.Results
{
  public class DataResult<TEntity> : Result, IDataResult<TEntity>
  {
    public DataResult(TEntity data, bool isSuccess, string message) : base(isSuccess, message)
    {
      Data = data;
    }

    public DataResult(TEntity data, bool isSuccess) : base(isSuccess)
    {
      Data = data;
    }

    public TEntity Data { get; }
  }
}
