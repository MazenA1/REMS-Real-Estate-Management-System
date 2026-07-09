using Models.FormData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOwnerApplicationService
    {
        bool RegisterOwner(OwnerFormData Data);

    }
}
