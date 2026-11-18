using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Domain.Common;

public abstract class BaseEntity<TId>
{
    public TId Id { get; set; } = default!  ;
}
