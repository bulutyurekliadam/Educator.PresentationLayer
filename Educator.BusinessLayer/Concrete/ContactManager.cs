using Educator.DataAccessLayer.Abstract;
using Educator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educator.BusinessLayer.Concrete
{
	public class ContactManager : IContactDal
	{
		private readonly IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void Delete(Contact t)
		{
			_contactDal.Delete(t);
		}

		public Contact GetByID(int id)
		{
			return _contactDal.GetByID(id);
		}

		public List<Contact> GetList()
		{
			return _contactDal.GetList();

		}

		public void Insert(Contact t)
		{
			_contactDal.Insert(t);
		}

		public void Update(Contact t)
		{
			_contactDal.Update(t);
		}
	}
}
