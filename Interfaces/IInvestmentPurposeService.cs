using System.Collections.Generic;

public interface IInvestmentPurposeService
{
    bool Save(InvestmentPurpose purpose);

    bool Deactivate(byte investmentPurposeID);

    InvestmentPurpose GetByID(byte investmentPurposeID);

    List<InvestmentPurpose> GetAll();

    List<InvestmentPurpose> GetAllActive();

    bool Exists(byte investmentPurposeID);
}