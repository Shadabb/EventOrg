using KNFive.Localization;
using Volo.Abp.AspNetCore.Components;

namespace KNFive.Blazor
{
    public abstract class KNFiveComponentBase : AbpComponentBase
    {
        protected KNFiveComponentBase()
        {
            LocalizationResource = typeof(KNFiveResource);
        }
    }
}
