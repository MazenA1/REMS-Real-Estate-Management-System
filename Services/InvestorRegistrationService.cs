using Interfaces;
using Models.FormData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class InvestorRegistrationService
        : IInvestorRegistrationService
    {
        private readonly IInvestorRegistrationRepository
            _repository;


        public InvestorRegistrationService(
            IInvestorRegistrationRepository repository)
        {
            _repository = repository;
        }


        public bool RegisterInvestor(
            InvestorRegistrationData data)
        {
            if (!_Validate(data))
                return false;


            return _repository.Register(data);
        }


        private bool _Validate(
            InvestorRegistrationData data)
        {
            if (data == null)
                return false;


            if (data.ClientRole == null)
                return false;


            if (data.Investor == null)
                return false;


            if (data.ClientRole.ClientID <= 0)
                return false;


            //if (data.ClientRole.ClientRoleTypeID <= 0)
            //    return false;


            if (data.Investor.PaymentMethodID <= 0)
                return false;


            if (data.Investor.InvestmentPurposeID <= 0)
                return false;


            if (data.Investor.InterestLevelID <= 0)
                return false;


            if (data.Investor.MinimumBudget.HasValue &&
                data.Investor.MinimumBudget.Value < 0)
            {
                return false;
            }


            if (data.Investor.MaximumBudget.HasValue &&
                data.Investor.MaximumBudget.Value < 0)
            {
                return false;
            }


            if (data.Investor.MinimumBudget.HasValue &&
                data.Investor.MaximumBudget.HasValue &&
                data.Investor.MinimumBudget >
                data.Investor.MaximumBudget)
            {
                return false;
            }


            return true;
        }
    }
}
