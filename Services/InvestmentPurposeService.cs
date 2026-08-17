using System.Collections.Generic;

public class InvestmentPurposeService
    : IInvestmentPurposeService
{
    private readonly IInvestmentPurposeRepository _repository;

    public InvestmentPurposeService(
        IInvestmentPurposeRepository repository)
    {
        _repository = repository;
    }

    private bool _AddInvestmentPurpose(
        InvestmentPurpose purpose)
    {
        int id = _repository.Add(purpose);

        if (id == -1)
            return false;

        purpose.InvestmentPurposeID = (byte)id;

        return true;
    }

    private bool _UpdateInvestmentPurpose(
        InvestmentPurpose purpose)
    {
        return _repository.Update(purpose);
    }

    public bool Save(InvestmentPurpose purpose)
    {
        if (purpose == null)
            return false;

        switch (purpose.Mode)
        {
            case InvestmentPurpose.enMode.AddNew:

                if (_AddInvestmentPurpose(purpose))
                {
                    purpose.Mode =
                        InvestmentPurpose.enMode.Update;

                    return true;
                }

                return false;

            case InvestmentPurpose.enMode.Update:

                return _UpdateInvestmentPurpose(purpose);
        }

        return false;
    }

    public bool Deactivate(
        byte investmentPurposeID)
    {
        if (investmentPurposeID == 0)
            return false;

        return _repository.Deactivate(
            investmentPurposeID);
    }

    public InvestmentPurpose GetByID(
        byte investmentPurposeID)
    {
        if (investmentPurposeID == 0)
            return null;

        return _repository.GetByID(
            investmentPurposeID);
    }

    public List<InvestmentPurpose> GetAll()
    {
        return _repository.GetAll();
    }

    public List<InvestmentPurpose> GetAllActive()
    {
        return _repository.GetAllActive();
    }

    public bool Exists(
        byte investmentPurposeID)
    {
        if (investmentPurposeID == 0)
            return false;

        return _repository.Exists(
            investmentPurposeID);
    }
}