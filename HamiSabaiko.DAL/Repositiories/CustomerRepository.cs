using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;
using HamiSabaiko.DAL.Abstract;
using HamiSabaiko.DAL.Interfaces;
using HamiSabaiko.Entities;

namespace HamiSabaiko.DAL.Repositories
{
    public class CustomerRepository : Repository<object>, ICustomerRepository
    {
        private IDatabase _dbcontext;
        public CustomerRepository(IDatabase dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomerAsync(int? id)
        {
            //var query = "SELECT TestID, TestName, TestTypeID ,MaterialTypeID FROM Test ";
            //return await DbContext.ExecuteReaderAsync("", CommandType.StoredProcedure, args =>
            //    {
            //        args.Add("@Source", id);
            //    },
            //    reader => new Customer
            //    {
            //        SerialNumber = reader.Get<int>(0),
            //        Name = reader.Get<string>(1),
            //        Amount = reader.Get<decimal>(2),
            //        LoanAmount = reader.Get<decimal>(3),


            //    });


        }
    }
}
