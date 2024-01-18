using System.Text.RegularExpressions;

namespace SmsServiceProject.Utils
{
    public class SmsUtils
    {
        public static string GetCountryCode(string phoneNumber)
        {
            if (phoneNumber.StartsWith("+357"))
            {
                return "CY";
            }
            else if (phoneNumber.StartsWith("+30"))
            {
                return "GR";
            }
            else
            {
                return "DEFAULT";
            }
        }

        public static bool IsGreekText(string text)
        {
            var greekRegex = new Regex(@"^[\u0370-\u03FF\s.,;:!?'\""-]+$");

            return greekRegex.IsMatch(text);
        }
    }
}