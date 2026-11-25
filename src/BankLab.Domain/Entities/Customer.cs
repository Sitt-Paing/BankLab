using BankLab.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Domain.Entities;

public class Customer : BaseAuditableEntity<Guid>
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public string PhoneNo { get; set; } = string.Empty;
    public string FatherName { get; set; } = string.Empty;
    public string Nrc { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}
