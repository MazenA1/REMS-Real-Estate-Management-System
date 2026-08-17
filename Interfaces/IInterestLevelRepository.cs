using System.Collections.Generic;

public interface IInterestLevelRepository
{
    int Add(InterestLevel interestLevel);

    bool Update(InterestLevel interestLevel);

    bool Deactivate(byte interestLevelID);

    InterestLevel GetByID(byte interestLevelID);

    List<InterestLevel> GetAll();

    List<InterestLevel> GetAllActive();

    bool Exists(byte interestLevelID);
}