using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class InvestmentPurposeRepository
    : IInvestmentPurposeRepository
{
    private readonly IAppLogger _logger;

    public InvestmentPurposeRepository(IAppLogger logger)
    {
        _logger = logger;
    }

    public int Add(InvestmentPurpose purpose)
    {
        try
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(
                    "@PurposeNameArabic",
                    purpose.PurposeNameArabic),

                new SqlParameter(
                    "@PurposeNameEnglish",
                    purpose.PurposeNameEnglish),

                new SqlParameter(
                    "@Description",
                    (object)purpose.Description ?? DBNull.Value),

                new SqlParameter(
                    "@IsActive",
                    purpose.IsActive),

                new SqlParameter(
                    "@DisplayOrder",
                    purpose.DisplayOrder)
            };

            object result = Helpers.SqlHelper.ExecuteScalar(
                "SP_AddInvestmentPurpose",
                parameters);

            return result != null &&
                   int.TryParse(result.ToString(), out int id)
                ? id
                : -1;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: InvestmentPurposeRepository | Method: Add | Exception: {ex}");

            return -1;
        }
    }

    public bool Update(InvestmentPurpose purpose)
    {
        try
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(
                    "@InvestmentPurposeID",
                    purpose.InvestmentPurposeID),

                new SqlParameter(
                    "@PurposeNameArabic",
                    purpose.PurposeNameArabic),

                new SqlParameter(
                    "@PurposeNameEnglish",
                    purpose.PurposeNameEnglish),

                new SqlParameter(
                    "@Description",
                    (object)purpose.Description ?? DBNull.Value),

                new SqlParameter(
                    "@IsActive",
                    purpose.IsActive),

                new SqlParameter(
                    "@DisplayOrder",
                    purpose.DisplayOrder)
            };

            object result = Helpers.SqlHelper.ExecuteScalar(
                "SP_UpdateInvestmentPurpose",
                parameters);

            return result != null &&
                   Convert.ToInt32(result) > 0;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: InvestmentPurposeRepository | Method: Update | Exception: {ex}");

            return false;
        }
    }

    public bool Deactivate(byte investmentPurposeID)
    {
        try
        {
            object result = Helpers.SqlHelper.ExecuteScalar(
                "SP_DeactivateInvestmentPurpose",
                new SqlParameter(
                    "@InvestmentPurposeID",
                    investmentPurposeID));

            return result != null &&
                   Convert.ToInt32(result) > 0;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: InvestmentPurposeRepository | Method: Deactivate | Exception: {ex}");

            return false;
        }
    }

    public InvestmentPurpose GetByID(byte investmentPurposeID)
    {
        try
        {
            using (SqlDataReader reader =
                Helpers.SqlHelper.ExecuteReader(
                    "SP_GetInvestmentPurposeByID",
                    new SqlParameter(
                        "@InvestmentPurposeID",
                        investmentPurposeID)))
            {
                if (reader.Read())
                    return _MapReaderToInvestmentPurpose(reader);

                return null;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: InvestmentPurposeRepository | Method: GetByID | Exception: {ex}");

            return null;
        }
    }

    public List<InvestmentPurpose> GetAll()
    {
        return _GetList("SP_GetAllInvestmentPurposes");
    }

    public List<InvestmentPurpose> GetAllActive()
    {
        return _GetList("SP_GetAllActiveInvestmentPurposes");
    }

    private List<InvestmentPurpose> _GetList(
        string storedProcedure)
    {
        List<InvestmentPurpose> list =
            new List<InvestmentPurpose>();

        try
        {
            using (SqlDataReader reader =
                Helpers.SqlHelper.ExecuteReader(
                    storedProcedure))
            {
                while (reader.Read())
                {
                    list.Add(
                        _MapReaderToInvestmentPurpose(reader));
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: InvestmentPurposeRepository | Method: _GetList | Exception: {ex}");
        }

        return list;
    }

    public bool Exists(byte investmentPurposeID)
    {
        try
        {
            object result = Helpers.SqlHelper.ExecuteScalar(
                "SP_IsInvestmentPurposeExist",
                new SqlParameter(
                    "@InvestmentPurposeID",
                    investmentPurposeID));

            return result != null &&
                   Convert.ToBoolean(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: InvestmentPurposeRepository | Method: Exists | Exception: {ex}");

            return false;
        }
    }

    private InvestmentPurpose _MapReaderToInvestmentPurpose(
        SqlDataReader reader)
    {
        return new InvestmentPurpose
        {
            InvestmentPurposeID =
                Convert.ToByte(
                    reader["InvestmentPurposeID"]),

            PurposeNameArabic =
                reader["PurposeNameArabic"].ToString(),

            PurposeNameEnglish =
                reader["PurposeNameEnglish"].ToString(),

            Description =
                reader["Description"] == DBNull.Value
                    ? null
                    : reader["Description"].ToString(),

            IsActive =
                Convert.ToBoolean(
                    reader["IsActive"]),

            DisplayOrder =
                Convert.ToByte(
                    reader["DisplayOrder"]),

            Mode =
                InvestmentPurpose.enMode.Update
        };
    }
}