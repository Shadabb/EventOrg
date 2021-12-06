using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using KNFive.Data;
using Volo.Abp.DependencyInjection;

namespace KNFive.EntityFrameworkCore
{
    public class EntityFrameworkCoreKNFiveDbSchemaMigrator
        : IKNFiveDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreKNFiveDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the KNFiveDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<KNFiveDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
