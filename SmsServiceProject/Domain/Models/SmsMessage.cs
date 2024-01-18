namespace SmsServiceProject.Domain.Models
{
    public class SmsMessage
    {
        public int Id { get; set; }

        public string PhoneNumber { get; set; }

        public string Message { get; set; }

        public string Vendor { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}