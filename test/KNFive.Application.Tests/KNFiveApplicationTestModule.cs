using Volo.Abp.Modularity;

namespace KNFive
{
    [DependsOn(
        typeof(KNFiveApplicationModule),
        typeof(KNFiveDomainTestModule)
        )]
    public class KNFiveApplicationTestModule : AbpModule
    {

    }
}