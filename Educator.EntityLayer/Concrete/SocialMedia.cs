﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educator.EntityLayer.Concrete
{
	public class SocialMedia
	{
		public int SocialMediaID { get; set; }
		public string SocialMediaName { get; set; }
		public string SocialMediaIcon { get; set; }
		public string SocialMediaUrl { get; set; }

		

	}
}
