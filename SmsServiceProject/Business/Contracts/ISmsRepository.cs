using SmsServiceProject.Dtos;

namespace SmsServiceProject.Business.Contracts
{
    public interface ISmsRepository
    {
        void SaveSms(InternalSmsRequestDto internalSmsRequest);
    }
}