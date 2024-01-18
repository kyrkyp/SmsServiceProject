using SmsServiceProject.Business.Contracts;
using SmsServiceProject.Dtos;
using SmsServiceProject.Utils;

namespace SmsServiceProject.Business.Vendors
{
    public class GreekVendorStrategy : IVendorStrategy
    {
        private readonly ISmsRepository _smsRepository;

        public GreekVendorStrategy(ISmsRepository smsRepository)
        {
            _smsRepository = smsRepository;
        }

        public SmsSendingResult HandleSms(string phoneNumber, string message)
        {
            if (!SmsUtils.IsGreekText(message))
            {
                return SmsSendingResult.FailureResult("Greek vendor can only send Greek text.");
            }

            var internalSmsRequest = new InternalSmsRequestDto
            {
                PhoneNumber = phoneNumber,
                Message = message,
                Vendor = "GreekVendor"
            };

            _smsRepository.SaveSms(internalSmsRequest);

            return SmsSendingResult.SuccessResult();
        }
    }
}