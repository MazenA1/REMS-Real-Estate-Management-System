using System.Collections.Generic;
using Models.DTOs;
using Models.Entities;

namespace Interfaces.Services
{
    public interface IUnitService
    {
        bool Save(Unit unit);

        bool Deactivate(int unitID);

        Unit FindByID(int unitID);

        List<Unit> GetAll();

        List<Unit> GetByBuildingID(int buildingID);

        List<UnitSelectionDTO> GetUnitsByPropertyID(int propertyID);

        bool Exists(int unitID);
    }
}