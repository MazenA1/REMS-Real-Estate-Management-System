using Interfaces;
using Interfaces.Services;
using Models.Entities;
using System.Collections.Generic;

namespace Services
{
    public class InvestorService : IInvestorService
    {
        private readonly IInvestorRepository _investorRepository;

        public InvestorService(
            IInvestorRepository investorRepository)
        {
            _investorRepository = investorRepository;
        }

        //=====================================================
        // Add
        //=====================================================

        private bool _AddInvestor(Investor investor)
        {
            int investorID =
                _investorRepository.Add(investor);

            if (investorID != -1)
            {
                investor.InvestorID = investorID;

                return true;
            }

            return false;
        }

        //=====================================================
        // Update
        //=====================================================

        private bool _UpdateInvestor(Investor investor)
        {
            return _investorRepository.Update(investor);
        }

        //=====================================================
        // Save
        //=====================================================

        public bool Save(Investor investor)
        {
            if (investor == null)
                return false;

            switch (investor.Mode)
            {
                case Investor.enMode.AddNew:

                    if (_AddInvestor(investor))
                    {
                        investor.Mode =
                            Investor.enMode.Update;

                        return true;
                    }

                    return false;

                case Investor.enMode.Update:

                    return _UpdateInvestor(investor);
            }

            return false;
        }

        //=====================================================
        // Delete
        //=====================================================

        public bool Delete(int investorID)
        {
            if (investorID <= 0)
                return false;

            return _investorRepository.Delete(investorID);
        }

        //=====================================================
        // Get By ID
        //=====================================================

        public Investor GetByID(int investorID)
        {
            if (investorID <= 0)
                return null;

            return _investorRepository.GetByID(investorID);
        }

        //=====================================================
        // Get By ClientRoleID
        //=====================================================

        public Investor GetByClientRoleID(int clientRoleID)
        {
            if (clientRoleID <= 0)
                return null;

            return _investorRepository
                .GetByClientRoleID(clientRoleID);
        }

        //=====================================================
        // Get All
        //=====================================================

        public List<Investor> GetAll()
        {
            return _investorRepository.GetAll();
        }

        //=====================================================
        // Exists
        //=====================================================

        public bool Exists(int investorID)
        {
            if (investorID <= 0)
                return false;

            return _investorRepository.Exists(investorID);
        }
    }
}