using Educator.BusinessLayer.Abstract;
using Educator.DataAccessLayer.Abstract;
using Educator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educator.BusinessLayer.Concrete
{
    public class CourseRegisterManager : ICourseRegisterService
    {
        private readonly ICourseRegisterDal _courseRegisterDal;

        public CourseRegisterManager(ICourseRegisterDal courseRegisterDal)
        {
            _courseRegisterDal = courseRegisterDal;
        }

        public List<CourseRegister> TCourseRegisterListWithCoursesAndUsers()
        {
            return _courseRegisterDal.CourseRegisterListWithCoursesAndUsers();
        }

        public void TDelete(CourseRegister t)
        {
            throw new NotImplementedException();
        }

        public CourseRegister TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<CourseRegister> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(CourseRegister t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(CourseRegister t)
        {
            throw new NotImplementedException();
        }
    }
}
