using SmsServiceProject.Utils;

namespace SmsServiceProject.Business.Contracts
{
    public interface IVendorStrategy
    {
        SmsSendingResult HandleSms(string phoneNumber, string message);
    }
}