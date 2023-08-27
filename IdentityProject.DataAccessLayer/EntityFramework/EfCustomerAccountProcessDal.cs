using IdentityProject.DataAccessLayer.Abstract;
using IdentityProject.DataAccessLayer.Repositories;
using IdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProject.DataAccessLayer.EntityFramework
{
    public class EfCustomerAccountProcessDal:GenericRepository<CustomerAccountProcess>,ICustomerAccountProcessDal
    {
    }
}
