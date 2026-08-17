using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IInvestorRepository
    {
        int Add(Investor investor);

        bool Update(Investor investor);

        bool Delete(int investorID);

        Investor GetByID(int investorID);

        Investor GetByClientRoleID(int clientRoleID);

        List<Investor> GetAll();

        bool Exists(int investorID);
    }
}
