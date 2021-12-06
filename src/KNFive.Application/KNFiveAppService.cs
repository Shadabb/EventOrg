using System;
using System.Collections.Generic;
using System.Text;
using KNFive.Localization;
using Volo.Abp.Application.Services;

namespace KNFive
{
    /* Inherit your application services from this class.
     */
    public abstract class KNFiveAppService : ApplicationService
    {
        protected KNFiveAppService()
        {
            LocalizationResource = typeof(KNFiveResource);
        }
    }
}
