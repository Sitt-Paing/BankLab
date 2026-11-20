using BankLab.Application.Common;
using BankLab.Application.Customers.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Application.Customers.Queries.GetCustomers;

public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, List<CustomerDto>>
{
    private readonly IApplicationDbContext _context;
    public GetCustomersQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<CustomerDto>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
    {
        return await _context.Customers
            .AsNoTracking()
            .Where(x => !x.DeletedOn.HasValue)
            .Select(x => new CustomerDto
            {
                Id = x.Id,
                FullName = x.FullName,
                Address = x.Address,
                DateOfBirth = x.DateOfBirth,
                PhoneNo = x.PhoneNo,
                FatherName = x.FatherName,
                Nrc = x.Nrc,
                IsActive = x.IsActive,
                CreatedOn = x.CreatedOn,
                CreatedBy = x.CreatedBy,
                UpdatedOn = x.UpdatedOn,
                UpdatedBy = x.UpdatedBy,
                DeletedOn = x.DeletedOn,
                DeletedBy = x.DeletedBy
            })
            .ToListAsync(cancellationToken);
       
    }
}
