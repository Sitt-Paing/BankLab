using BankLab.Application.Common;
using BankLab.Application.Customers.DTOs;
using BankLab.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Application.Customers.Commands.UpdateCustomer;

public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, CustomerDto?>
{
    private readonly IApplicationDbContext _context;
    public UpdateCustomerCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<CustomerDto?> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        Customer? customer = await _context.Customers.AsNoTracking().Where(x => !x.DeletedOn.HasValue).FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if(customer == null) throw new Exception($"Customer with Id {request.Id} not found.");

        customer.FullName = request.FullName;
        customer.FatherName = request.FatherName;
        customer.Address = request.Address;
        customer.DateOfBirth = request.DateOfBirth;
        customer.Nrc = request.Nrc;
        await _context.SaveChangesAsync(cancellationToken);
        return new CustomerDto
        {
            Id = customer.Id,
            FullName = customer.FullName,
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