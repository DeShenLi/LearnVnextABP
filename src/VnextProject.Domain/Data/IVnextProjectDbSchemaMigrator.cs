using System.Threading.Tasks;

namespace VnextProject.Data
{
    public interface IVnextProjectDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
