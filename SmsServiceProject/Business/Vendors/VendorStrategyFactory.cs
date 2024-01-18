using SmsServiceProject.Business.Contracts;

namespace SmsServiceProject.Business.Vendors
{
    public class VendorStrategyFactory
    {
        private readonly Dictionary<string, IVendorStrategy> _strategies;

        public VendorStrategyFactory(
            GreekVendorStrategy greekVendorStrategy,
            CypriotVendorStrategy cypriotVendorStrategy,
            RestOfWorldVendorStrategy restOfWorldVendorStrategy)
        {
            _strategies = new Dictionary<string, IVendorStrategy>
            {
                { "GR", greekVendorStrategy },
                { "CY", cypriotVendorStrategy },
                { "DEFAULT", restOfWorldVendorStrategy }
            };
        }

        public IVendorStrategy GetVendorStrategy(string countryCode)
        {
            if (_strategies.TryGetValue(countryCode, out var strategy))
            {
                return strategy;
            }

            return _strategies["DEFAULT"];
        }
    }
}