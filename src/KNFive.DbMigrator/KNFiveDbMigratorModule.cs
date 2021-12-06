using KNFive.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace KNFive.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(KNFiveEntityFrameworkCoreModule),
        typeof(KNFiveApplicationContractsModule)
        )]
    public class KNFiveDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
