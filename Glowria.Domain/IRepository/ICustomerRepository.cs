using Identity.Domain.Entities;

namespace Glowria.Domain.IRepository;

public interface ICustomerRepository : IGenericRepository<Customer>
{
    Task AddCustomer(Customer customer, string password);
    Task<ApplicationUser> GetByEmail(string email);
}