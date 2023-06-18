using Educator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educator.BusinessLayer.Abstract
{
    public interface ICourseRegisterService : IGenericService<CourseRegister>
    {
        List<CourseRegister> TCourseRegisterListWithCoursesAndUsers();
        List<CourseRegister> TCourseRegisterListWithCourseByUser(int id);
    }
}
