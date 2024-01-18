using SmsServiceProject.Business.Contracts;
using SmsServiceProject.Dtos;
using SmsServiceProject.Utils;

namespace SmsServiceProject.Business.Vendors
{
    public class RestOfWorldVendorStrategy : IVendorStrategy
    {
        private readonly ISmsRepository _smsRepository;

        public RestOfWorldVendorStrategy(ISmsRepository smsRepository)
        {
            _smsRepository = smsRepository;
        }

        public SmsSendingResult HandleSms(string phoneNumber, string message)
        {
            var internalSmsRequest = new InternalSmsRequestDto
            {
                PhoneNumber = phoneNumber,
                Message = message,
                Vendor = "RestOfWorldVendor"
            };

            _smsRepository.SaveSms(internalSmsRequest);

            return SmsSendingResult.SuccessResult();
        }
    }
}