using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp.Core.Utilities.Results
{
  public class ErrorDataResult<TEntity> : DataResult<TEntity>
  {
    public ErrorDataResult(TEntity data, bool isSuccess, string message) : base(data, false, message)
    {
    }

    public ErrorDataResult(TEntity data, string message) : base(data, false, message)
    {
    }

    public ErrorDataResult(bool isSuccess, string message) : base(default, false, message)
    {
    }

    public ErrorDataResult(string message) : base(default, false, message)
    {
    }
    
    public ErrorDataResult(TEntity data) : base(data, false)
    {
    }

    public ErrorDataResult() : base(default, false)
    {
    }


  }
}
