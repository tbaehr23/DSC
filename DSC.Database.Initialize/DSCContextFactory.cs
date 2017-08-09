using Microsoft.EntityFrameworkCore;

// ReSharper disable InconsistentNaming

namespace DSC.Database.Initialize
{
    public static class DSCContextFactory
    {
        public static DSCContext InMemoryContext()
        {
            var optionInMemory = new DbContextOptionsBuilder<DSCContext>().UseInMemoryDatabase().Options;

            var context = new DSCContext(optionInMemory);

            Initializer.PopulateDatabaseWithSeedData(context);

            return context;
        }
    }
}
