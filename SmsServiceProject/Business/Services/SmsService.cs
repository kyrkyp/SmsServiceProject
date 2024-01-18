using FluentValidation;
using SmsServiceProject.Business.Contracts;
using SmsServiceProject.Business.Validators;
using SmsServiceProject.Business.Vendors;
using SmsServiceProject.Dtos;
using SmsServiceProject.Utils;

namespace SmsServiceProject.Business.Services
{
    public class SmsService : ISmsService
    {
        private readonly VendorStrategyFactory _vendorStrategyFactory;
        private readonly IValidator<SmsRequestDto> _validator;

        public SmsService(VendorStrategyFactory vendorStrategyFactory)
        {
            _vendorStrategyFactory = vendorStrategyFactory;
            _validator = new SmsRequestDtoValidator();
        }

        public SmsSendingResult SendSms(SmsRequestDto request)
        {
            var validationResult = _validator.Validate(request);

            if (!validationResult.IsValid)
            {
                var errorMessage = string.Join("; ", validationResult.Errors.Select(e => $"{e.PropertyName}: {e.ErrorMessage}"));

                return SmsSendingResult.FailureResult(errorMessage);
            }

            var countryCode = SmsUtils.GetCountryCode(request.PhoneNumber);

            var vendorStrategy = _vendorStrategyFactory.GetVendorStrategy(countryCode);

            return vendorStrategy.HandleSms(request.PhoneNumber, request.Message);
        }
    }
}