using BankLab.Application.Common.Interfaces;
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
        Customer? customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == request.Id && !x.DeletedOn.HasValue,cancellationToken);

        if (customer is null)
        {
            return null;
        }

        customer.FullName = request.FullName;
        customer.Email = request.Email;
        customer.PhoneNo = request.PhoneNo;
        customer.FatherName = request.FatherName;
        customer.Address = request.Address;
        customer.DateOfBirth = request.DateOfBirth;
        customer.Nrc = request.Nrc;
        await _context.SaveChangesAsync(cancellationToken);
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