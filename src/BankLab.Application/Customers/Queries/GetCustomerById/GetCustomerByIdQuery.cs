using BankLab.Application.Customers.DTOs;
using MediatR;

namespace BankLab.Application.Customers.Queries.GetCustomerById;

public record GetCustomerByIdQuery(long Id) : IRequest<CustomerDto?>;