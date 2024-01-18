using SmsServiceProject.Dtos;
using SmsServiceProject.Utils;

namespace SmsServiceProject.Business.Contracts
{
    public interface ISmsService
    {
        SmsSendingResult SendSms(SmsRequestDto request);
    }
}