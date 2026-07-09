using Interfaces;
using Models;
using System.Collections.Generic;

public class DistrictService : IDistrictService
{
    private readonly IDistrictRepository _districtRepository;

    public DistrictService(IDistrictRepository districtRepository)
    {
        _districtRepository = districtRepository;
    }

    public List<District> GetAll()
    {
        return _districtRepository.GetAll();
    }

    public List<District> GetByCityID(int cityID)
    {
        return _districtRepository.GetByCityID(cityID);
    }
}