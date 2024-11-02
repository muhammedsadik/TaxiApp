using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp.Core.Utilities.Results
{
  public class SuccessDataResult<TEntity> : DataResult<TEntity>
  {
    public SuccessDataResult(TEntity data, bool isSuccess, string message) : base(data, true, message)
    {
    }

    public SuccessDataResult(TEntity data, string message) : base(data, true, message)
    {
    }

    public SuccessDataResult(bool isSuccess, string message) : base(default, true, message)
    {
    }

    public SuccessDataResult(string message) : base(default, true, message)
    {
    }
    
    public SuccessDataResult(TEntity data) : base(data, true)
    {
    }

    public SuccessDataResult() : base(default, true)
    {
    }
    

  }
}
