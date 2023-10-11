using DataAccesslayer.Abstract;
using DataAccesslayer.Concrete;
using DataAccesslayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            using (var context = new Context())
            {
                var values = context.ContactUses.Where(x => x.MessageStatus == true).ToList();
                return values;
            }
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            using(var context=new Context())
            {

                var values=context.ContactUses.Where(x => x.MessageStatus == false).ToList();
                return values;
            }
        }
    }
}
