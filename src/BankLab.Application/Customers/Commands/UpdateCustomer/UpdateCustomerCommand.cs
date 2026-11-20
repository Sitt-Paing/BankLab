using BankLab.Application.Customers.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Application.Customers.Commands.UpdateCustomer;

public record UpdateCustomerCommand(long Id, string FullName,string Email, string Address, DateOnly DateOfBirth, string PhoneNo, string FatherName, string Nrc) : IRequest<CustomerDto?>;