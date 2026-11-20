using BankLab.Application.Common.Interfaces;
using BankLab.Application.Customers.DTOs;
using BankLab.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Application.Customers.Commands.CreateCustomer;

public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CustomerDto>
{
    private readonly IApplicationDbContext _context;
    public CreateCustomerCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<CustomerDto> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = new Customer
        {
            FullName = request.FullName,
            Email = request.Email,
            Address = request.Address,
            DateOfBirth = request.DateOfBirth,
            PhoneNo = request.PhoneNo,
            FatherName = request.FatherName,
            Nrc = request.Nrc
        };
        _context.Customers.Add(customer);
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
