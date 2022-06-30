using Microsoft.EntityFrameworkCore;
using SoftDelete.Interfaces;
using SoftDelete.Models;

namespace SoftDelete.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void ManageSoftDeleteBehavoir(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType))
                {
                    entityType.AddSoftDeleteQueryFilter();
                }
            }
        } 
      
    }
}
