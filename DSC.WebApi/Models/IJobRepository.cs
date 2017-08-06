using System.Collections.Generic;

namespace DSC.WebApi.Models
{
    public interface IJobRepository
    {
        IEnumerable<Job> GetList();
        Job GetById(int id);
        Job Save(Job jobToSave);
        Job Delete(Job jobToDelete);
    }
}
