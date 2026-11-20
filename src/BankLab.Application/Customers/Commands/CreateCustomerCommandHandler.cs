using BankLab.Application.Common;
using BankLab.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Application.Customers.Commands;

public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, long>
{
    private readonly IApplicationDbContext _context;
    public CreateCustomerCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<long> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = new Customer
        {
            FullName = request.FullName,
            Address = request.Address,
            DateOfBirth = request.DateOfBirth,
            PhoneNo = request.PhoneNo,
            FatherName = request.FatherName,
            Nrc = request.Nrc
        };
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync(cancellationToken);
        return customer.Id;
    }
}
