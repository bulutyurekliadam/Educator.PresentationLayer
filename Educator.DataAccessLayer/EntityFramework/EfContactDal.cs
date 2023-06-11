using Educator.DataAccessLayer.Abstract;
using Educator.DataAccessLayer.Concrete;
using Educator.DataAccessLayer.Repositories;
using Educator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Educator.DataAccessLayer.EntityFramework
{
	public class EfContactDal:GenericRepository<Contact>, IContactDal
	{
		public List<Contact> GetLast4Message()
		{
			using var context = new Context();
			var values = context.Contacts.OrderByDescending(x=>x.ContactID).Take(4).ToList();
			return values;
		}

	}
}
