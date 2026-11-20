using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Application.Customers.Commands;

public record CreateCustomerCommand(string FullName, string Address, DateOnly DateOfBirth, string PhoneNo, string FatherName, string Nrc) : IRequest<long>;