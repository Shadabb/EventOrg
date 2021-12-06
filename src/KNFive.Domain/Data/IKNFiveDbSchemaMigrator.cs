using System.Threading.Tasks;

namespace KNFive.Data
{
    public interface IKNFiveDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
