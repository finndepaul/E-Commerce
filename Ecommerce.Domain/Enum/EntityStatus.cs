using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Enum
{
    public enum EntityStatus
    {
        Active = 1,
        InActive = 2,
        Deleted = 3,
        Pending = 4,
        PendingForActivation = 5,
        PendingForConfirmation = 6,
        PendingForApproval = 7,
        Locked = 8,
    }
}
