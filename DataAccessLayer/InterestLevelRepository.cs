using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class InterestLevelRepository : IInterestLevelRepository
{
    private readonly IAppLogger _logger;

    public InterestLevelRepository(IAppLogger logger)
    {
        _logger = logger;
    }

    public int Add(InterestLevel interestLevel)
    {
        try
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(
                    "@InterestLevelNameArabic",
                    interestLevel.InterestLevelNameArabic),

                new SqlParameter(
                    "@InterestLevelNameEnglish",
                    interestLevel.InterestLevelNameEnglish),

                new SqlParameter(
                    "@Description",
                    (object)interestLevel.Description ?? DBNull.Value),

                new SqlParameter(
                    "@IsActive",
                    interestLevel.IsActive),

                new SqlParameter(
                    "@DisplayOrder",
                    interestLevel.DisplayOrder)
            };

            object result = Helpers.SqlHelper.ExecuteScalar(
                "SP_AddInterestLevel",
                parameters);

            return result != null &&
                   int.TryParse(result.ToString(), out int id)
                ? id
                : -1;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: InterestLevelRepository | Method: Add | Exception: {ex}");

            return -1;
        }
    }

    public bool Update(InterestLevel interestLevel)
    {
        try
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(
                    "@InterestLevelID",
                    interestLevel.InterestLevelID),

                new SqlParameter(
                    "@InterestLevelNameArabic",
                    interestLevel.InterestLevelNameArabic),

                new SqlParameter(
                    "@InterestLevelNameEnglish",
                    interestLevel.InterestLevelNameEnglish),

                new SqlParameter(
                    "@Description",
                    (object)interestLevel.Description ?? DBNull.Value),

                new SqlParameter(
                    "@IsActive",
                    interestLevel.IsActive),

                new SqlParameter(
                    "@DisplayOrder",
                    interestLevel.DisplayOrder)
            };

            object result = Helpers.SqlHelper.ExecuteScalar(
                "SP_UpdateInterestLevel",
                parameters);

            return result != null &&
                   Convert.ToInt32(result) > 0;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: InterestLevelRepository | Method: Update | Exception: {ex}");

            return false;
        }
    }

    public bool Deactivate(byte interestLevelID)
    {
        try
        {
            object result = Helpers.SqlHelper.ExecuteScalar(
                "SP_DeactivateInterestLevel",
                new SqlParameter(
                    "@InterestLevelID",
                    interestLevelID));

            return result != null &&
                   Convert.ToInt32(result) > 0;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: InterestLevelRepository | Method: Deactivate | Exception: {ex}");

            return false;
        }
    }

    public InterestLevel GetByID(byte interestLevelID)
    {
        try
        {
            using (SqlDataReader reader =
                Helpers.SqlHelper.ExecuteReader(
                    "SP_GetInterestLevelByID",
                    new SqlParameter(
                        "@InterestLevelID",
                        interestLevelID)))
            {
                if (reader.Read())
                    return _MapReaderToInterestLevel(reader);

                return null;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: InterestLevelRepository | Method: GetByID | Exception: {ex}");

            return null;
        }
    }

    public List<InterestLevel> GetAll()
    {
        return _GetList("SP_GetAllInterestLevels");
    }

    public List<InterestLevel> GetAllActive()
    {
        return _GetList("SP_GetAllActiveInterestLevels");
    }

    private List<InterestLevel> _GetList(string storedProcedure)
    {
        List<InterestLevel> list =
            new List<InterestLevel>();

        try
        {
            using (SqlDataReader reader =
                Helpers.SqlHelper.ExecuteReader(storedProcedure))
            {
                while (reader.Read())
                {
                    list.Add(
                        _MapReaderToInterestLevel(reader));
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: InterestLevelRepository | Method: _GetList | Exception: {ex}");
        }

        return list;
    }

    public bool Exists(byte interestLevelID)
    {
        try
        {
            object result = Helpers.SqlHelper.ExecuteScalar(
                "SP_IsInterestLevelExist",
                new SqlParameter(
                    "@InterestLevelID",
                    interestLevelID));

            return result != null &&
                   Convert.ToBoolean(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: InterestLevelRepository | Method: Exists | Exception: {ex}");

            return false;
        }
    }

    private InterestLevel _MapReaderToInterestLevel(
        SqlDataReader reader)
    {
        return new InterestLevel
        {
            InterestLevelID =
                Convert.ToByte(reader["InterestLevelID"]),

            InterestLevelNameArabic =
                reader["InterestLevelNameArabic"].ToString(),

            InterestLevelNameEnglish =
                reader["InterestLevelNameEnglish"].ToString(),

            Description =
                reader["Description"] == DBNull.Value
                    ? null
                    : reader["Description"].ToString(),

            IsActive =
                Convert.ToBoolean(reader["IsActive"]),

            DisplayOrder =
                Convert.ToByte(reader["DisplayOrder"]),

            Mode = InterestLevel.enMode.Update
        };
    }
}