using DSC.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;
// ReSharper disable InconsistentNaming

namespace DSC.WebApi.Test.JobController
{
    [Collection("DSC")]
    public class When_Post_executes
    {
        private IActionResult _result;

        [Fact]
        public void With_a_new_job_Then_a_CreatedAtRouteResult_is_returned()
        {
            using (var context = DSCContextFactory.InMemoryContext())
            {
                var controller = new Controllers.JobController(new Models.JobRepository(context));

                _result = controller.Post(new Job());
            }

            Assert.IsType<CreatedAtRouteResult>(_result);
        }

        [Fact]
        public void With_a_null_Then_a_BadRequestResult_is_returned()
        {
            using (var context = DSCContextFactory.InMemoryContext())
            {
                var controller = new Controllers.JobController(new Models.JobRepository(context));

                _result = controller.Post(null);
            }

            Assert.IsType<BadRequestResult>(_result);
        }

    }
}
