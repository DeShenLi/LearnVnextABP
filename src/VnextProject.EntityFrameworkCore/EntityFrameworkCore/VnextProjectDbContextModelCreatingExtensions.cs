using Microsoft.EntityFrameworkCore;
using VnextProject.Entity;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace VnextProject.EntityFrameworkCore
{
    public static class VnextProjectDbContextModelCreatingExtensions
    {
        public static void ConfigureVnextProject(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));
            /* Configure your own tables/entities inside here */

            builder.Entity<Book>(b =>
            {
                b.ToTable(VnextProjectConsts.DbTablePrefix + "Book", VnextProjectConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
                //...
            });
        }
    }
}