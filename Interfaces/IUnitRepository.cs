using System.Collections.Generic;
using Models.DTOs;
using Models.Entities;

namespace Interfaces.Repositories
{
    public interface IUnitRepository
    {
        int Add(Unit unit);

        bool Update(Unit unit);

        bool Deactivate(int unitID);

        Unit GetByID(int unitID);

        List<Unit> GetAll();

        List<Unit> GetByBuildingID(int buildingID);

        List<UnitSelectionDTO> GetUnitsByPropertyID(int propertyID);

        bool Exists(int unitID);
    }
}