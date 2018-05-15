using HamiSabaiko.BAL.Interfaces;
using HamiSabaiko.DAL.Interfaces;
using HamiSabaiko.Entities;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace HamiSabaiko.BAL.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _repo;
        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }
        public async Task<IEnumerable<Customer>> GetAllCustomerAsync(int? id)
        {
           return await _repo.GetAllCustomerAsync(id);
            
        }
    }
}
