using BankLab.Application.Common.Interfaces;
using BankLab.Application.Customers.DTOs;
using BankLab.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Application.Customers.Queries.GetCustomerById;

public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDto?>
{
    private readonly IApplicationDbContext _context;
    public GetCustomerByIdQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<CustomerDto?> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
    {
        Customer? customer = await _context.Customers.AsNoTracking().Where(x => !x.DeletedOn.HasValue).FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (customer == null) return null;
        return new CustomerDto
        {
            Id = customer.Id,
            FullName = customer.FullName,
            Email = customer.Email,
            FatherName = customer.FatherName,
            PhoneNo = customer.PhoneNo,
            Address = customer.Address,
            DateOfBirth = customer.DateOfBirth,
            Nrc = customer.Nrc,
            IsActive = customer.IsActive,
            CreatedOn = customer.CreatedOn,
            CreatedBy = customer.CreatedBy,
            UpdatedOn = customer.UpdatedOn,
            UpdatedBy = customer.UpdatedBy,
            DeletedOn = customer.DeletedOn,
            DeletedBy = customer.DeletedBy
        };
    }
}
