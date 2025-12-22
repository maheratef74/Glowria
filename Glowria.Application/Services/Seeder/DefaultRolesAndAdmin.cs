using Identity.Domain;
using Identity.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Glowria.Application.Services.Seeder;

public static class DefaultRolesAndAdmin
{
    public static async Task SeedAsync(
        RoleManager<IdentityRole> roleManager,
        UserManager<ApplicationUser> userManager)
    {
        // Seed Roles
        if (!roleManager.Roles.Any())
        {
            await roleManager.CreateAsync(new IdentityRole(Role.Admin));
            await roleManager.CreateAsync(new IdentityRole(Role.Customer));
        }

        // Seed Admin User
        string adminEmail = "admin@gmail.com";
        string adminPassword = "123456";

        var existingAdmin = await userManager.FindByEmailAsync(adminEmail);
        if (existingAdmin == null)
        {
            var admin = new Admin
            {
                UserName = adminEmail,
                Email = adminEmail,
                PhoneNumber = adminEmail,
            };

            var result = await userManager.CreateAsync(admin, adminPassword);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(admin, Role.Admin);
            }
        }
    }
}