﻿using Educator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.ViewComponents.Default
{
    public class _CoursePartial:ViewComponent
    {
        private readonly ICourseService _courseService;
        public _CoursePartial (ICourseService courseService)
        {
            _courseService = courseService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _courseService.TGetCoursesWithCategories();
            return View(values);
        }
    }
}
