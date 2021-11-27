using System;
namespace StockManagement.Core.Results.Concrete
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(true, message)
        {
        }


        public ErrorResult() : base(false)
        {
        }
    }
}
