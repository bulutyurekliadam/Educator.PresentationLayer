using Educator.DataAccessLayer.Abstract;
using Educator.DataAccessLayer.Repositories;
using Educator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educator.DataAccessLayer.EntityFramework
{
    public class EfAboutGridDal : GenericRepository<AboutGrid>, IAboutGridDal
    {
    }
}
