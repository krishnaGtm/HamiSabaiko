using HamiSabaiko.DAL.Interfaces.Base;
using HamiSabaiko.Entities;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace HamiSabaiko.DAL.Interfaces
{
    public interface ICustomerRepository: IRepository<object>
    {
        Task<IEnumerable<Customer>> GetAllCustomerAsync(int? id);
    }
}
