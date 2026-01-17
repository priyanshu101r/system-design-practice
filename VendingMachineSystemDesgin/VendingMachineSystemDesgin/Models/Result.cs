namespace VendingMachineSystemDesgin.Models
{
    public class Result
    {
        public bool IsSuccess { get; }
        public string Message { get; }

        private Result(bool success, string message)
        {
            IsSuccess = success;
            Message = message;
        }

        public static Result Success(string msg = "Success")
            => new Result(true, msg);

        public static Result Failure(string msg)
            => new Result(false, msg);

        public override string ToString()
            => IsSuccess ? $"{Message}" : $"{Message}";
    }
}
