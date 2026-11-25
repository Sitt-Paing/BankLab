namespace BankLab.Domain.Common;

public interface IAuditableEntity
{
    DateTime? CreatedOn { get; set; }
    string? CreatedBy { get; set; }
    DateTime? UpdatedOn { get; set; }
    string? UpdatedBy { get; set; }
    DateTime? DeletedOn { get; set; }
    string? DeletedBy { get; set; }
}
