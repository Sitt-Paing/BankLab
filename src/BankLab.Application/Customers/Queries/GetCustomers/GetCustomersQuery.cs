using BankLab.Application.Customers.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Application.Customers.Queries.GetCustomers;

public record GetCustomersQuery() : IRequest<List<CustomerDto>>;
