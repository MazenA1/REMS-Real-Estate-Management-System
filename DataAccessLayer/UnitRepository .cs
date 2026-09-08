using Helpers;
using Interfaces;
using Interfaces.Repositories;
using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositories
{
    public class UnitRepository : IUnitRepository
    {
        private readonly IAppLogger _logger;


        public UnitRepository(IAppLogger logger)
        {
            _logger = logger;
        }


        // =========================================
        // Add
        // =========================================

        public int Add(Unit unit)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter(
                        "@BuildingID",
                        unit.BuildingID),

                    new SqlParameter(
                        "@UnitNumber",
                        unit.UnitNumber),

                    new SqlParameter(
                        "@UnitTypeID",
                        unit.UnitTypeID),

                    new SqlParameter(
                        "@FloorNumber",
                        SqlHelper.ToDbValue(unit.FloorNumber)),

                    new SqlParameter(
                        "@Area",
                        SqlHelper.ToDbValue(unit.Area)),

                    new SqlParameter(
                        "@CreatedByUserID",
                        unit.CreatedByUserID),

                    new SqlParameter(
                        "@Notes",
                        SqlHelper.ToDbValue(unit.Notes))
                };


                object result =
                    SqlHelper.ExecuteScalar(
                        "SP_AddUnit",
                        parameters);


                if (result == null ||
                    result == DBNull.Value)
                {
                    return -1;
                }


                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "UnitRepository.Add",
                    ex);

                return -1;
            }
        }


        // =========================================
        // Update
        // =========================================

        public bool Update(Unit unit)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter(
                        "@UnitID",
                        unit.UnitID),

                    new SqlParameter(
                        "@BuildingID",
                        unit.BuildingID),

                    new SqlParameter(
                        "@UnitNumber",
                        unit.UnitNumber),

                    new SqlParameter(
                        "@UnitTypeID",
                        unit.UnitTypeID),

                    new SqlParameter(
                        "@FloorNumber",
                        SqlHelper.ToDbValue(unit.FloorNumber)),

                    new SqlParameter(
                        "@Area",
                        SqlHelper.ToDbValue(unit.Area)),

                    new SqlParameter(
                        "@Notes",
                        SqlHelper.ToDbValue(unit.Notes))
                };


                object result =
                    SqlHelper.ExecuteScalar(
                        "SP_UpdateUnit",
                        parameters);


                if (result == null ||
                    result == DBNull.Value)
                {
                    return false;
                }


                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "UnitRepository.Update",
                    ex);

                return false;
            }
        }


        // =========================================
        // Deactivate
        // =========================================

        public bool Deactivate(int unitID)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter(
                        "@UnitID",
                        unitID)
                };


                object result =
                    SqlHelper.ExecuteScalar(
                        "SP_DeactivateUnit",
                        parameters);


                if (result == null ||
                    result == DBNull.Value)
                {
                    return false;
                }


                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "UnitRepository.Deactivate",
                    ex);

                return false;
            }
        }


        // =========================================
        // Get By ID
        // =========================================

        public Unit GetByID(int unitID)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter(
                        "@UnitID",
                        unitID)
                };


                using (SqlDataReader reader =
                    SqlHelper.ExecuteReader(
                        "SP_GetUnitByID",
                        parameters))
                {
                    if (reader.Read())
                    {
                        return _MapUnit(reader);
                    }
                }


                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "UnitRepository.GetByID",
                    ex);

                return null;
            }
        }


        // =========================================
        // Get All
        // =========================================

        public List<Unit> GetAll()
        {
            List<Unit> units =
                new List<Unit>();


            try
            {
                using (SqlDataReader reader =
                    SqlHelper.ExecuteReader(
                        "SP_GetAllUnits"))
                {
                    while (reader.Read())
                    {
                        units.Add(
                            _MapUnit(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "UnitRepository.GetAll",
                    ex);
            }


            return units;
        }


        // =========================================
        // Get By Building
        // =========================================

        public List<Unit> GetByBuildingID(
            int buildingID)
        {
            List<Unit> units =
                new List<Unit>();


            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter(
                        "@BuildingID",
                        buildingID)
                };


                using (SqlDataReader reader =
                    SqlHelper.ExecuteReader(
                        "SP_GetUnitsByBuildingID",
                        parameters))
                {
                    while (reader.Read())
                    {
                        units.Add(
                            _MapUnit(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "UnitRepository.GetByBuildingID",
                    ex);
            }


            return units;
        }


        // =========================================
        // Get Units For Property Selector
        // =========================================

        public List<UnitSelectionDTO>
            GetUnitsByPropertyID(int propertyID)
        {
            List<UnitSelectionDTO> units =
                new List<UnitSelectionDTO>();


            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter(
                        "@PropertyID",
                        propertyID)
                };


                using (SqlDataReader reader =
                    SqlHelper.ExecuteReader(
                        "SP_GetUnitsByPropertyID",
                        parameters))
                {
                    while (reader.Read())
                    {
                        units.Add(
                            _MapUnitSelection(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "UnitRepository.GetUnitsByPropertyID",
                    ex);
            }


            return units;
        }


        // =========================================
        // Exists
        // =========================================

        public bool Exists(int unitID)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter(
                        "@UnitID",
                        unitID)
                };


                object result =
                    SqlHelper.ExecuteScalar(
                        "SP_IsUnitExist",
                        parameters);


                if (result == null ||
                    result == DBNull.Value)
                {
                    return false;
                }


                return Convert.ToBoolean(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "UnitRepository.Exists",
                    ex);

                return false;
            }
        }


        // =========================================
        // Mapper - Unit
        // =========================================

        private Unit _MapUnit(
            SqlDataReader reader)
        {
            Unit unit = new Unit();


            unit.UnitID =
                Convert.ToInt32(
                    reader["UnitID"]);

            unit.BuildingID =
                Convert.ToInt32(
                    reader["BuildingID"]);

            unit.UnitCode =
                (Guid)reader["UnitCode"];

            unit.UnitNumber =
                reader["UnitNumber"].ToString();

            unit.UnitTypeID =
                Convert.ToByte(
                    reader["UnitTypeID"]);


            unit.FloorNumber =
                reader["FloorNumber"] == DBNull.Value
                    ? (short?)null
                    : Convert.ToInt16(
                        reader["FloorNumber"]);


            unit.Area =
                reader["Area"] == DBNull.Value
                    ? (decimal?)null
                    : Convert.ToDecimal(
                        reader["Area"]);


            unit.IsActive =
                Convert.ToBoolean(
                    reader["IsActive"]);

            unit.CreatedDate =
                Convert.ToDateTime(
                    reader["CreatedDate"]);

            unit.CreatedByUserID =
                Convert.ToInt32(
                    reader["CreatedByUserID"]);


            unit.Notes =
                reader["Notes"] == DBNull.Value
                    ? null
                    : reader["Notes"].ToString();


            unit.Mode =
                Unit.enMode.Update;


            return unit;
        }


        // =========================================
        // Mapper - Selection DTO
        // =========================================

        private UnitSelectionDTO
            _MapUnitSelection(
                SqlDataReader reader)
        {
            UnitSelectionDTO dto =
                new UnitSelectionDTO();


            dto.UnitID =
                Convert.ToInt32(
                    reader["UnitID"]);

            dto.BuildingID =
                Convert.ToInt32(
                    reader["BuildingID"]);

            dto.UnitNumber =
                reader["UnitNumber"].ToString();

            dto.UnitTypeID =
                Convert.ToByte(
                    reader["UnitTypeID"]);

            dto.UnitTypeName =
                reader["UnitTypeName"].ToString();

            dto.BuildingNumber =
                reader["BuildingNumber"].ToString();


            dto.BuildingName =
                reader["BuildingName"] == DBNull.Value
                    ? null
                    : reader["BuildingName"].ToString();


            dto.FloorNumber =
                reader["FloorNumber"] == DBNull.Value
                    ? (short?)null
                    : Convert.ToInt16(
                        reader["FloorNumber"]);


            dto.Area =
                reader["Area"] == DBNull.Value
                    ? (decimal?)null
                    : Convert.ToDecimal(
                        reader["Area"]);


            dto.IsActive =
                Convert.ToBoolean(
                    reader["IsActive"]);


            return dto;
        }
    }
}