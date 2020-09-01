using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace VnextProject.Data
{
    /* This is used if database provider does't define
     * IVnextProjectDbSchemaMigrator implementation.
     */
    public class NullVnextProjectDbSchemaMigrator : IVnextProjectDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}