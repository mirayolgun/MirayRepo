using System;
using System.Collections.Generic;
using System.Text;

namespace API.Infrastructure.Utilities.Result
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
