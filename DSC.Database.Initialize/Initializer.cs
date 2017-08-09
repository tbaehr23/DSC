using System.Linq;

namespace DSC.Database.Initialize
{
    public static class Initializer
    {
        public static void PopulateDatabaseWithSeedData(DSCContext context)
        {
            if (!context.Jobs.Any())
            {
                context.Jobs.AddRange(SeedData.Jobs());
                context.SaveChanges();
            }
        }
    }
}
