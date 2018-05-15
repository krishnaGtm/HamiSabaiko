using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;
using HamiSabaiko.DAL.Abstract;
using HamiSabaiko.DAL.Interfaces.Base;
using HamiSabaiko.DAL.Interfaces;

namespace HamiSabaiko.DAL.Repositories
{
    public class CustomerRepository : Repository<object>, ICustomer
    {
        public CustomerRepository(IDatabase dbContext) : base(dbContext)
        {
        }
        
    }
}
