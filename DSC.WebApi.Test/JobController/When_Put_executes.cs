using DSC.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;
// ReSharper disable InconsistentNaming

namespace DSC.WebApi.Test.JobController
{
    [Collection("DSC")]
    public class When_Put_executes
    {
        private IActionResult _result;

        [Fact]
        public void With_a_valid_job_and_an_Id_value_of_the_valid_job_Then_a_NoContentResult_is_returned()
        {
            using (var context = DSCContextFactory.InMemoryContext())
            {
                var controller = new Controllers.JobController(new Models.JobRepository(context));

                _result = controller.Put(1, new Job{ Id = 1 });
            }

            Assert.IsType<NoContentResult>(_result);
        }

        [Fact]
        public void With_a_invalid_job_and_an_Id_value_of_the_invalid_job_Then_a_NotFoundResult_is_returned()
        {
            using (var context = DSCContextFactory.InMemoryContext())
            {
                var controller = new Controllers.JobController(new Models.JobRepository(context));

                _result = controller.Put(3, new Job { Id = 3 });
            }

            Assert.IsType<NotFoundResult>(_result);
        }


        [Fact]
        public void With_a_null_job_Then_a_BadRequestResult_is_returned()
        {
            using (var context = DSCContextFactory.InMemoryContext())
            {
                var controller = new Controllers.JobController(new Models.JobRepository(context));

                _result = controller.Put(1, null);
            }

            Assert.IsType<BadRequestResult>(_result);
        }

        [Fact]
        public void With_a_valid_job_and_an_Id_value__not_of_the_valid_job_Then_a_BadRequestResult_is_returned()
        {
            using (var context = DSCContextFactory.InMemoryContext())
            {
                var controller = new Controllers.JobController(new Models.JobRepository(context));

                _result = controller.Put(1, new Job { Id = 2 });
            }

            Assert.IsType<BadRequestResult>(_result);
        }

    }
}
