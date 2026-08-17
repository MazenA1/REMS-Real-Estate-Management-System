using System.Collections.Generic;

public interface IInterestLevelService
{
    bool Save(InterestLevel interestLevel);

    bool Deactivate(byte interestLevelID);

    InterestLevel GetByID(byte interestLevelID);

    List<InterestLevel> GetAll();

    List<InterestLevel> GetAllActive();

    bool Exists(byte interestLevelID);
}