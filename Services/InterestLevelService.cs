using System.Collections.Generic;

public class InterestLevelService : IInterestLevelService
{
    private readonly IInterestLevelRepository _repository;

    public InterestLevelService(
        IInterestLevelRepository repository)
    {
        _repository = repository;
    }

    private bool _AddInterestLevel(
        InterestLevel interestLevel)
    {
        int id = _repository.Add(interestLevel);

        if (id == -1)
            return false;

        interestLevel.InterestLevelID = (byte)id;

        return true;
    }

    private bool _UpdateInterestLevel(
        InterestLevel interestLevel)
    {
        return _repository.Update(interestLevel);
    }

    public bool Save(InterestLevel interestLevel)
    {
        if (interestLevel == null)
            return false;

        switch (interestLevel.Mode)
        {
            case InterestLevel.enMode.AddNew:

                if (_AddInterestLevel(interestLevel))
                {
                    interestLevel.Mode =
                        InterestLevel.enMode.Update;

                    return true;
                }

                return false;

            case InterestLevel.enMode.Update:

                return _UpdateInterestLevel(
                    interestLevel);
        }

        return false;
    }

    public bool Deactivate(byte interestLevelID)
    {
        if (interestLevelID == 0)
            return false;

        return _repository.Deactivate(
            interestLevelID);
    }

    public InterestLevel GetByID(
        byte interestLevelID)
    {
        if (interestLevelID == 0)
            return null;

        return _repository.GetByID(
            interestLevelID);
    }

    public List<InterestLevel> GetAll()
    {
        return _repository.GetAll();
    }

    public List<InterestLevel> GetAllActive()
    {
        return _repository.GetAllActive();
    }

    public bool Exists(byte interestLevelID)
    {
        if (interestLevelID == 0)
            return false;

        return _repository.Exists(
            interestLevelID);
    }
}