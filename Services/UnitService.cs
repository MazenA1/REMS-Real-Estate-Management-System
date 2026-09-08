using System;
using System.Collections.Generic;
using Interfaces.Repositories;
using Interfaces.Services;
using Models.DTOs;
using Models.Entities;

namespace Services
{
    public class UnitService : IUnitService
    {
        private readonly IUnitRepository
            _unitRepository;


        public UnitService(
            IUnitRepository unitRepository)
        {
            _unitRepository =
                unitRepository;
        }


        // =========================================
        // Add
        // =========================================

        private bool _AddUnit(Unit unit)
        {
            int unitID =
                _unitRepository.Add(unit);


            if (unitID <= 0)
                return false;


            unit.UnitID = unitID;

            return true;
        }


        // =========================================
        // Update
        // =========================================

        private bool _UpdateUnit(Unit unit)
        {
            return
                _unitRepository.Update(unit);
        }


        // =========================================
        // Save
        // =========================================

        public bool Save(Unit unit)
        {
            if (unit == null)
                return false;


            if (!_Validate(unit))
                return false;


            switch (unit.Mode)
            {
                case Unit.enMode.AddNew:

                    if (_AddUnit(unit))
                    {
                        unit.Mode =
                            Unit.enMode.Update;

                        return true;
                    }

                    return false;


                case Unit.enMode.Update:

                    return _UpdateUnit(unit);
            }


            return false;
        }


        // =========================================
        // Validation
        // =========================================

        private bool _Validate(Unit unit)
        {
            if (unit.BuildingID <= 0)
                return false;


            if (string.IsNullOrWhiteSpace(
                unit.UnitNumber))
            {
                return false;
            }


            if (unit.UnitTypeID <= 0)
                return false;


            if (unit.Area.HasValue &&
                unit.Area.Value < 0)
            {
                return false;
            }


            return true;
        }


        // =========================================
        // Deactivate
        // =========================================

        public bool Deactivate(int unitID)
        {
            if (unitID <= 0)
                return false;


            return
                _unitRepository.Deactivate(
                    unitID);
        }


        // =========================================
        // Find
        // =========================================

        public Unit FindByID(int unitID)
        {
            if (unitID <= 0)
                return null;


            return
                _unitRepository.GetByID(
                    unitID);
        }


        // =========================================
        // Get All
        // =========================================

        public List<Unit> GetAll()
        {
            return
                _unitRepository.GetAll();
        }


        // =========================================
        // Get By Building
        // =========================================

        public List<Unit>
            GetByBuildingID(int buildingID)
        {
            if (buildingID <= 0)
            {
                return
                    new List<Unit>();
            }


            return
                _unitRepository
                    .GetByBuildingID(
                        buildingID);
        }


        // =========================================
        // Selector
        // =========================================

        public List<UnitSelectionDTO>
            GetUnitsByPropertyID(int propertyID)
        {
            if (propertyID <= 0)
            {
                return
                    new List<UnitSelectionDTO>();
            }


            return
                _unitRepository
                    .GetUnitsByPropertyID(
                        propertyID);
        }


        // =========================================
        // Exists
        // =========================================

        public bool Exists(int unitID)
        {
            if (unitID <= 0)
                return false;


            return
                _unitRepository.Exists(
                    unitID);
        }
    }
}