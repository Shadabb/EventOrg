using KNFive.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace KNFive
{
    [DependsOn(
        typeof(KNFiveEntityFrameworkCoreTestModule)
        )]
    public class KNFiveDomainTestModule : AbpModule
    {

    }
}