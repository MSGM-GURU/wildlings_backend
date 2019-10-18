using System.Collections.Generic;

namespace wildlings_backend.Models.Service.Interface
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourse();
        void Register(int customerId, int courseId);
        void Cancel(int customerId, int courseId);
        void Renew(int customerId, int courseId);
    }
}