using Models.Entities;
using System.Collections.Generic;

namespace Interfaces.Services
{
    public interface IInvestorService
    {
        bool Save(Investor investor);

        bool Delete(int investorID);

        Investor GetByID(int investorID);

        Investor GetByClientRoleID(int clientRoleID);

        List<Investor> GetAll();

        bool Exists(int investorID);
    }
}