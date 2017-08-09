using System;
using DSC.Database.Initialize;
using Microsoft.AspNetCore.Mvc;
using Xunit;
// ReSharper disable InconsistentNaming

namespace DSC.WebApi.Test.JobController
{
    [Collection("DSC")]
    public class When_Delete_executes
    {
        private IActionResult _result;

        [Theory,
         InlineData(1, typeof(NoContentResult)),
         InlineData(2, typeof(NoContentResult)),
         InlineData(3, typeof(NotFoundResult))]
        public void Then_correct_result_type_is_returned(int id, Type resultType)
        {
            using (var context = DSCContextFactory.InMemoryContext())
            {
                var controller = new Controllers.JobController(new Models.JobRepository(context));

                _result = controller.Delete(1);
            }

            Assert.IsType(resultType, _result);
        }
    }
}
