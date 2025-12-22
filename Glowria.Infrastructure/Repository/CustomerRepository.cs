using Glowria.Domain.IRepository;
using Identity.Domain;
using Identity.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Glowria.Infrastructure.Repository;

public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    private readonly AppDbContext _appDbContext;
    private readonly UserManager<ApplicationUser> _userManager;

    public CustomerRepository(AppDbContext appDbContext, UserManager<ApplicationUser> userManager) : base(appDbContext)
    {
        _appDbContext = appDbContext;
        _userManager = userManager;
    }

    public async Task AddCustomer(Customer customer, string password)
    {
        await _userManager.CreateAsync(customer, password);
        await _userManager.AddToRoleAsync(customer, Role.Customer);
    }

    public async Task<ApplicationUser?> GetByEmail(string email)
    {
        var customer = _appDbContext.Users
            .FirstOrDefault(c => c.Email == email);
        return customer;
    }
}