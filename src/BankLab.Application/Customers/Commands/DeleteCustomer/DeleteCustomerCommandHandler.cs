using BankLab.Application.Common.Interfaces;
using BankLab.Application.Customers.DTOs;
using BankLab.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Application.Customers.Commands.DeleteCustomer;

public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, CustomerDto?>
{
    private readonly IApplicationDbContext _context;
    public DeleteCustomerCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<CustomerDto?> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
    {
        Customer? customer = await _context.Customers.AsNoTracking().Where(x => !x.DeletedOn.HasValue).FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (customer is null)
        {
            return null;
        }
        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync(cancellationToken);
        return new CustomerDto
        {
            Id = customer.Id,
            FullName = customer.FullName,
            Email = customer.Email,
            Address = customer.Address,
            DateOfBirth = customer.DateOfBirth,
            PhoneNo = customer.PhoneNo,
            FatherName = customer.FatherName,
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
