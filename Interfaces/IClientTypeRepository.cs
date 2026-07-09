using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IClientTypeRepository
    {
        List<ClientType> GetAll();
    }
}