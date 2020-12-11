using System;

namespace CodeSamples.Useful
{
    internal class Result
    {
        public static Result<T> Success<T>(T obj)
        {
            return new Result<T>(true, obj);
        }

        public static Result<T> Error<T>(string errorMessage)
        {
            return new Result<T>(false, errorMessage);
        }
    }

    internal class Result<T>
    {
        public bool IsSuccess { get; private set; }
        public T Value { get; private set; }

        public string ErrorMessage { get; private set; }

        public Result(bool success, T obj = default)
        {
            IsSuccess = success;
            Value = obj;
        }

        public Result(bool success, string message)
        {
            IsSuccess = success;
            ErrorMessage = message;
        }
    }

    public class ResultSample : SampleExecute
    {
        private Result<int> ReturnSuccessful()
        {
            return Result.Success(4);
        }

        private Result<int> ReturnError()
        {
            return Result.Error<int>("Something went wrong!");
        }

        public override void Execute()
        {
            Title("ResultSampleExecute");

            var success = ReturnSuccessful();

            if (success.IsSuccess)
            {
                Console.WriteLine($"Yey! Call was Successful, result is {success.Value}");
            }

            var error = ReturnError();

            if (!error.IsSuccess)
            {
                Console.WriteLine($"Oops! There was an error with message '{error.ErrorMessage}'");
            }

            Finish();
        }
    }
}
