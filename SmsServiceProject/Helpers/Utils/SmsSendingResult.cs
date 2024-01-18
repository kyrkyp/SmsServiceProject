namespace SmsServiceProject.Utils
{
    public class SmsSendingResult
    {
        public bool IsSuccess { get; set; }

        public string ErrorMessage { get; set; }

        public static SmsSendingResult SuccessResult() =>
            new SmsSendingResult { IsSuccess = true };

        public static SmsSendingResult FailureResult(string errorMessage) =>
            new SmsSendingResult { IsSuccess = false, ErrorMessage = errorMessage };
    }
}