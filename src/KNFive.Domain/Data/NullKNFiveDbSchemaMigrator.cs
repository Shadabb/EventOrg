using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace KNFive.Data
{
    /* This is used if database provider does't define
     * IKNFiveDbSchemaMigrator implementation.
     */
    public class NullKNFiveDbSchemaMigrator : IKNFiveDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}