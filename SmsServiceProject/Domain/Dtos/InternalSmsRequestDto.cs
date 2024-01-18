namespace SmsServiceProject.Dtos
{
    public class InternalSmsRequestDto
    {
        public string PhoneNumber { get; set; }

        public string Message { get; set; }

        public string Vendor { get; set; }
    }
}