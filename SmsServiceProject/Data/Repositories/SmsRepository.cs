using SmsServiceProject.Business.Contracts;
using SmsServiceProject.Domain;
using SmsServiceProject.Domain.Models;
using SmsServiceProject.Dtos;

namespace SmsServiceProject.Data.Repositories
{
    public class SmsRepository : ISmsRepository
    {
        private readonly SmsMessageDbContext _dbContext;

        public SmsRepository(SmsMessageDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveSms(InternalSmsRequestDto internalSmsRequest)
        {
            var sms = new SmsMessage
            {
                PhoneNumber = internalSmsRequest.PhoneNumber,
                Message = internalSmsRequest.Message,
                Vendor = internalSmsRequest.Vendor,
                CreatedAt = DateTime.Now
            };

            _dbContext.SmsMessages.Add(sms);
            _dbContext.SaveChanges();
        }
    }
}