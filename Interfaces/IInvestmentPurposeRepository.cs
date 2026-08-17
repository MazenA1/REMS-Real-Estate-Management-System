using System.Collections.Generic;

public interface IInvestmentPurposeRepository
{
    int Add(InvestmentPurpose purpose);

    bool Update(InvestmentPurpose purpose);

    bool Deactivate(byte investmentPurposeID);

    InvestmentPurpose GetByID(byte investmentPurposeID);

    List<InvestmentPurpose> GetAll();

    List<InvestmentPurpose> GetAllActive();

    bool Exists(byte investmentPurposeID);
}