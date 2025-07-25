﻿using Educator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educator.DataAccessLayer.Abstract
{
	public  interface ICourseDal:IGenericDal<Course>
	{
		List<Course> GetCoursesWithCategory();
		List<Course> GetCoursesWithCategories();
		List<Course> GetLast5Course();


	}
}
