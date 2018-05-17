using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using HamiSabaiko.DAL.Abstract;
using HamiSabaiko.DAL.Extensions;
using HamiSabaiko.DAL.Interfaces;
using HamiSabaiko.DAL.Interfaces.Base;
using HamiSabaiko.Entities;

namespace HamiSabaiko.DAL.Repositiories
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
            var query = "SELECT TestID, TestName, TestTypeID ,MaterialTypeID FROM Test ";
            return await DbContext.ExecuteReaderAsync(query, CommandType.Text, args =>
                {
                    args.Add("@Source", id);
                },
                reader => new Customer
                {
                    SerialNumber = reader.Get<int>(0),
                    Name = reader.Get<string>(1),
                    Amount = reader.Get<int>(2),
                    LoanAmount = reader.Get<int>(3),


                });


        }
    }
}
