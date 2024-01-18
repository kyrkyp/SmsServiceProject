using Microsoft.EntityFrameworkCore;
using SmsServiceProject.Domain.Models;

namespace SmsServiceProject.Domain
{
    public class SmsMessageDbContext : DbContext
    {
        public DbSet<SmsMessage> SmsMessages { get; set; }

        public SmsMessageDbContext(DbContextOptions<SmsMessageDbContext> options)
            : base(options)
        {
        }
    }
}