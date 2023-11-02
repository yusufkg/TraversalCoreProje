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
    public class EfAccountDal:GenericUowRepository<Account>,IAccountDal
    {
        public EfAccountDal(Context context):base(context)
        {

        }
    }
}
