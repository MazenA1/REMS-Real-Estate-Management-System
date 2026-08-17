using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class PaymentMethodRepository : IPaymentMethodRepository
{
    private readonly IAppLogger _logger;

    public PaymentMethodRepository(IAppLogger logger)
    {
        _logger = logger;
    }

    public int Add(PaymentMethod paymentMethod)
    {
        try
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(
                    "@PaymentMethodNameArabic",
                    paymentMethod.PaymentMethodNameArabic),

                new SqlParameter(
                    "@PaymentMethodNameEnglish",
                    paymentMethod.PaymentMethodNameEnglish),

                new SqlParameter(
                    "@IsActive",
                    paymentMethod.IsActive),

                new SqlParameter(
                    "@DisplayOrder",
                    paymentMethod.DisplayOrder)
            };

            object result = Helpers.SqlHelper.ExecuteScalar(
                "SP_AddPaymentMethod",
                parameters);

            return result != null &&
                   int.TryParse(result.ToString(), out int id)
                ? id
                : -1;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: PaymentMethodRepository | Method: Add | Exception: {ex}");

            return -1;
        }
    }

    public bool Update(PaymentMethod paymentMethod)
    {
        try
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(
                    "@PaymentMethodID",
                    paymentMethod.PaymentMethodID),

                new SqlParameter(
                    "@PaymentMethodNameArabic",
                    paymentMethod.PaymentMethodNameArabic),

                new SqlParameter(
                    "@PaymentMethodNameEnglish",
                    paymentMethod.PaymentMethodNameEnglish),

                new SqlParameter(
                    "@IsActive",
                    paymentMethod.IsActive),

                new SqlParameter(
                    "@DisplayOrder",
                    paymentMethod.DisplayOrder)
            };

            object result = Helpers.SqlHelper.ExecuteScalar(
                "SP_UpdatePaymentMethod",
                parameters);

            return result != null &&
                   Convert.ToInt32(result) > 0;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: PaymentMethodRepository | Method: Update | Exception: {ex}");

            return false;
        }
    }

    public bool Deactivate(byte paymentMethodID)
    {
        try
        {
            object result = Helpers.SqlHelper.ExecuteScalar(
                "SP_DeactivatePaymentMethod",
                new SqlParameter(
                    "@PaymentMethodID",
                    paymentMethodID));

            return result != null &&
                   Convert.ToInt32(result) > 0;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: PaymentMethodRepository | Method: Deactivate | Exception: {ex}");

            return false;
        }
    }

    public PaymentMethod GetByID(byte paymentMethodID)
    {
        try
        {
            using (SqlDataReader reader =
                Helpers.SqlHelper.ExecuteReader(
                    "SP_GetPaymentMethodByID",
                    new SqlParameter(
                        "@PaymentMethodID",
                        paymentMethodID)))
            {
                if (reader.Read())
                    return _MapReaderToPaymentMethod(reader);

                return null;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: PaymentMethodRepository | Method: GetByID | Exception: {ex}");

            return null;
        }
    }

    public List<PaymentMethod> GetAll()
    {
        return _GetList("SP_GetAllPaymentMethods");
    }

    public List<PaymentMethod> GetAllActive()
    {
        return _GetList("SP_GetAllActivePaymentMethods");
    }

    private List<PaymentMethod> _GetList(string storedProcedure)
    {
        List<PaymentMethod> list =
            new List<PaymentMethod>();

        try
        {
            using (SqlDataReader reader =
                Helpers.SqlHelper.ExecuteReader(storedProcedure))
            {
                while (reader.Read())
                {
                    list.Add(
                        _MapReaderToPaymentMethod(reader));
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: PaymentMethodRepository | Method: _GetList | Exception: {ex}");
        }

        return list;
    }

    public bool Exists(byte paymentMethodID)
    {
        try
        {
            object result = Helpers.SqlHelper.ExecuteScalar(
                "SP_IsPaymentMethodExist",
                new SqlParameter(
                    "@PaymentMethodID",
                    paymentMethodID));

            return result != null &&
                   Convert.ToBoolean(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | Class: PaymentMethodRepository | Method: Exists | Exception: {ex}");

            return false;
        }
    }

    private PaymentMethod _MapReaderToPaymentMethod(
        SqlDataReader reader)
    {
        return new PaymentMethod
        {
            PaymentMethodID =
                Convert.ToByte(reader["PaymentMethodID"]),

            PaymentMethodNameArabic =
                reader["PaymentMethodNameArabic"].ToString(),

            PaymentMethodNameEnglish =
                reader["PaymentMethodNameEnglish"].ToString(),

            IsActive =
                Convert.ToBoolean(reader["IsActive"]),

            DisplayOrder =
                Convert.ToByte(reader["DisplayOrder"]),

            Mode = PaymentMethod.enMode.Update
        };
    }
}