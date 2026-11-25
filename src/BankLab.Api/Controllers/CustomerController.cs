using BankLab.Application.Customers.Commands;
using BankLab.Application.Customers.DTOs;
using BankLab.Application.Customers.Queries.GetCustomerById;
using BankLab.Application.Customers.Queries.GetCustomers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BankLab.Api.Controllers;

[Authorize]
[Route("api/customers")]
[ApiController]
public class CustomerController(ISender sender) : ControllerBase
{
    [HttpGet]
    [EndpointSummary("Get all customers.")]
    public async Task<ActionResult<CustomerDto[]>> GetAllCustomers(CancellationToken cancellationToken)
    {
        var customers = await sender.Send(new GetCustomersQuery(), cancellationToken);
        return Ok(customers);
    }

    [HttpGet("{id}")]
    [EndpointSummary("Get a customer by ID.")]
    public async Task<ActionResult<CustomerDto>> GetCustomerById(Guid id, CancellationToken cancellationToken)
    {
        var customer = await sender.Send(new GetCustomerByIdQuery(id), cancellationToken);
        if(customer is null)
        {
            return NotFound();
        }   
        return Ok(customer);
    }

    [HttpPost]
    [EndpointSummary("Create a new customer.")]
    public async Task<ActionResult<CustomerDto>> CreateCustomer(CreateCustomerCommand command, CancellationToken cancellationToken)
    {
        var customer = await sender.Send(command, cancellationToken);
        return StatusCode(StatusCodes.Status201Created, customer);
    }
}
