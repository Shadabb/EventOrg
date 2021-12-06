using KNFive.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace KNFive.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class KNFiveController : AbpController
    {
        protected KNFiveController()
        {
            LocalizationResource = typeof(KNFiveResource);
        }
    }
}