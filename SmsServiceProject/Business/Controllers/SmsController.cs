using Microsoft.AspNetCore.Mvc;
using SmsServiceProject.Business.Contracts;
using SmsServiceProject.Dtos;

namespace SmsServiceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmsController : ControllerBase
    {
        private readonly ISmsService _smsService;

        public SmsController(ISmsService smsService)
        {
            _smsService = smsService;
        }

        [HttpPost]
        public IActionResult SendSms([FromBody] SmsRequestDto request)
        {
            var result = _smsService.SendSms(request);

            if (!result.IsSuccess)
            {
                return BadRequest(result.ErrorMessage);
            }

            return Ok("SMS sent successfully.");
        }
    }
}