using System;
using System.Collections.Generic;
using System.Text;

namespace BankLab.Application.Common;

public interface ICurrentUserService
{
    string? UserId { get; }
    string? UserName { get; }
}
