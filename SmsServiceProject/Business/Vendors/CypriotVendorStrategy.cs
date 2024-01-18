using SmsServiceProject.Business.Contracts;
using SmsServiceProject.Dtos;
using SmsServiceProject.Utils;

namespace SmsServiceProject.Business.Vendors
{
    public class CypriotVendorStrategy : IVendorStrategy
    {
        private const int MaxSmsLength = 160;
        private readonly ISmsRepository _smsRepository;

        public CypriotVendorStrategy(ISmsRepository smsRepository)
        {
            _smsRepository = smsRepository;
        }

        public SmsSendingResult HandleSms(string phoneNumber, string message)
        {
            var messageParts = SplitMessage(message);

            foreach (var part in messageParts)
            {
                var internalSmsRequest = new InternalSmsRequestDto
                {
                    PhoneNumber = phoneNumber,
                    Message = part,
                    Vendor = "CypriotVendor"
                };

                _smsRepository.SaveSms(internalSmsRequest);
            }

            return SmsSendingResult.SuccessResult();
        }

        private IEnumerable<string> SplitMessage(string message)
        {
            for (int i = 0; i < message.Length; i += MaxSmsLength)
            {
                yield return message.Substring(i, Math.Min(MaxSmsLength, message.Length - i));
            }
        }
    }
}