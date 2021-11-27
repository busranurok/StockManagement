using System;
using StockManagement.Core.Results.Abstract;

namespace StockManagement.Core.Results.Concrete
{
    public class Result : IResult
    {
        public Result()
        {
        }

        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message {get;}
    }
}
