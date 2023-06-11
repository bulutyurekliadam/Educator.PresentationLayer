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
    public class MailSubscribeManager : IMailSubscribeService
    {
        private readonly IMailSubscribeDal _mailSubscirbeDal;

        public MailSubscribeManager(IMailSubscribeDal mailSubscirbeDal)
        {
            _mailSubscirbeDal = mailSubscirbeDal;
        }

        public void TDelete(MailSubscribe t)
        {
            throw new NotImplementedException();
        }

        public MailSubscribe TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MailSubscribe> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(MailSubscribe t)
        {
            _mailSubscirbeDal.Insert(t); 
        }

        public void TUpdate(MailSubscribe t)
        {
            throw new NotImplementedException();
        }
    }
}
