using System;
using System.Collections.Generic;
using System.Text;

namespace API.Infrastructure.Utilities.Result
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
