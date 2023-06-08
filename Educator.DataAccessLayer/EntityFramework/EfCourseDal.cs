using Educator.DataAccessLayer.Abstract;
using Educator.DataAccessLayer.Concrete;
using Educator.DataAccessLayer.Repositories;
using Educator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educator.DataAccessLayer.EntityFramework
{
    public class EfCourseDal : GenericRepository<Course>, ICourseDal
    {
        public List<Course> GetCoursesWithCategories()
        {
            Context context = new Context();
            return context.Courses.Include(x => x.Category).ToList();
        }

        public List<Course> GetCoursesWithCategory()
        {
            Context context = new Context();
            return context.Courses.Include(x => x.Category).ToList();
        }
    }
}
