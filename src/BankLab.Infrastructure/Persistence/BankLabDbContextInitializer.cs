using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Infrastructure.Persistence;

public class BankLabDbContextInitializer(RoleManager<IdentityRole<Guid>> roleManager)
{
    public async Task SeedRolesAsync()
    {
        string[] roleNames = { "Admin", "Customer", "Employee" };
        foreach(var roleName in roleNames)
        {
            if(await roleManager.RoleExistsAsync(roleName)) continue;

            IdentityRole<Guid> role = new IdentityRole<Guid> { Name = roleName };
            IdentityResult result = await roleManager.CreateAsync(role);

            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new InvalidOperationException(
                    $"Could not create role '{roleName}': {errors}");
            }
        }
    }
}