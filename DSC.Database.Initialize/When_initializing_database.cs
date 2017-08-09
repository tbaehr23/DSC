using DSC.Database.Domain;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DSC.Database.Initialize
{
    public class When_initializing_database
    {
        [Fact]
        public void Then_database_should_have_seed_data()
        {
            var jobs = new List<Job>();

            using (var context = new DSCContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                Initializer.PopulateDatabaseWithSeedData(context);

                jobs.AddRange(context.Jobs.ToList());
            }

            Assert.True(jobs.Any(), "No seed data in Jobs table");
        }
    }
}
