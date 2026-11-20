using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Application.Customers.DTOs;

public record class CustomerDto
{
    public long Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public string PhoneNo { get; set; } = string.Empty;
    public string FatherName { get; set; } = string.Empty;
    public string Nrc { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public DateTime? CreatedOn { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? DeletedOn { get; set; }
    public string? DeletedBy { get; set; }
}
