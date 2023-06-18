using Educator.DataAccessLayer.Abstract;
using Educator.DataAccessLayer.Concrete;
using Educator.DataAccessLayer.Repositories;
using Educator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Educator.DataAccessLayer.EntityFramework
{
    public class EfCourseRegisterDal : GenericRepository<CourseRegister>, ICourseRegisterDal
    {
        public List<CourseRegister> CourseRegisterListWithCourseByUser(int id)
        {
            using var context = new Context();
            var values = context.CourseRegisters.Where(y => y.AppUserID == id).Include(x => x.Course).ToList();
            return values;
        }

        public List<CourseRegister> CourseRegisterListWithCoursesAndUsers()
        {
            using var context = new Context();
            var values = context.CourseRegisters.Include(x => x.Course).Include(y => y.AppUser).ToList();
            return values;
        }
    }
}
