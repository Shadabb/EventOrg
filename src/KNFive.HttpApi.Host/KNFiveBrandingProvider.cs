using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace KNFive
{
    [Dependency(ReplaceServices = true)]
    public class KNFiveBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "KNFive";
    }
}
