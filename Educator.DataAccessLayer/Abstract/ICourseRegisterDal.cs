﻿using Educator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educator.DataAccessLayer.Abstract
{
    public interface ICourseRegisterDal : IGenericDal<CourseRegister>
    {
        List<CourseRegister> CourseRegisterListWithCoursesAndUsers();
        List<CourseRegister> CourseRegisterListWithCourseByUser(int id);
    }
}
