using System.Collections.Generic;
using wildlings_backend.Models.Service.Interface;

namespace wildlings_backend.Models.Service
{
    public class CourseService : ICourseService
    {
        public IEnumerable<Course> GetAllCourse()
        {
            throw new System.NotImplementedException();
        }

        public void Register(int customerId, int courseId)
        {
            throw new System.NotImplementedException();
        }

        public void Cancel(int customerId, int courseId)
        {
            throw new System.NotImplementedException();
        }

        public void Renew(int customerId, int courseId)
        {
            throw new System.NotImplementedException();
        }
    }
}