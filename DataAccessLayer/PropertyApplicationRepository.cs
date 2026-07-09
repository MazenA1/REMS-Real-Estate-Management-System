using Helpers;
using Interfaces;
using Models;
using Models.FormData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class PropertyApplicationRepository : IPropertyApplicationRepository 
    {
        private readonly IAppLogger _logger;

        public PropertyApplicationRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        private DataTable _CreateOwnershipsDataTable(List<PropertyOwnership> ownerships)
        {
            DataTable table = new DataTable();

            table.Columns.Add("OwnerID", typeof(int));
            table.Columns.Add("OwnershipPercentage", typeof(decimal));
            table.Columns.Add("IsPrimaryOwner", typeof(bool));
            table.Columns.Add("DeedNumber", typeof(string));
            table.Columns.Add("DeedDate", typeof(DateTime));
            table.Columns.Add("LandNumber", typeof(string));
            table.Columns.Add("OwnershipStatusID", typeof(int));
            table.Columns.Add("DeedImagePath", typeof(string));

            foreach (var item in ownerships)
            {
                DataRow row = table.NewRow();

                row["OwnerID"] = item.OwnerID;
                row["OwnershipPercentage"] = item.OwnershipPercentage;
                row["IsPrimaryOwner"] = item.IsPrimaryOwner;
                row["DeedNumber"] = string.IsNullOrWhiteSpace(item.DeedNumber)
                    ? (object)DBNull.Value
                    : item.DeedNumber;

                row["DeedDate"] = item.DeedDate.HasValue
                    ? (object)item.DeedDate.Value
                    : DBNull.Value;

                row["LandNumber"] = string.IsNullOrWhiteSpace(item.LandNumber)
                    ? (object)DBNull.Value
                    : item.LandNumber;

                row["OwnershipStatusID"] = item.OwnershipStatusID.HasValue
                    ? (object)item.OwnershipStatusID.Value
                    : DBNull.Value;

                row["DeedImagePath"] = string.IsNullOrWhiteSpace(item.DeedImagePath)
                    ? (object)DBNull.Value
                    : item.DeedImagePath;

                table.Rows.Add(row);
            }

            return table;
        }
        public int Add(PropertyRegistrationData data)
        {
            try
            {
                DataTable ownershipsTable =
                    _CreateOwnershipsDataTable(data.PropertyOwnership);

                SqlParameter ownershipsParam = new SqlParameter("@Ownerships", ownershipsTable);
                ownershipsParam.SqlDbType = SqlDbType.Structured;
                ownershipsParam.TypeName = "dbo.PropertyOwnershipTableType";

                object result = SqlHelper.ExecuteScalar(
                    "SP_RegisterProperty",

                    new SqlParameter("@PropertyName", data.Property.PropertyName),
                    new SqlParameter("@PropertyTypeID", data.Property.PropertyTypeID),
                    new SqlParameter("@Address", SqlHelper.ToDbValue(data.Property.Address)),
                    new SqlParameter("@CityID", data.Property.CityID),
                    new SqlParameter("@DistrictID", data.Property.DistrictID),
                    new SqlParameter("@Area", SqlHelper.ToDbValue(data.Property.Area)),
                    new SqlParameter("@BuildingYear", SqlHelper.ToDbValue(data.Property.BuildingYear)),
                    new SqlParameter("@Description", SqlHelper.ToDbValue(data.Property.Description)),
                    new SqlParameter("@ManagementCommissionValue", SqlHelper.ToDbValue(data.Property.ManagementCommissionValue)),
                    new SqlParameter("@ManagementCommissionTypeID", data.Property.ManagementCommissionTypeID),
                    new SqlParameter("@IsSubjectToVAT", data.Property.IsSubjectToVAT),
                    new SqlParameter("@CreatedByUserID", data.Property.CreatedByUserID),

                    ownershipsParam,

                    new SqlParameter("@Rating", SqlHelper.ToDbValue(data.PropertyEvaluation.Rating)),
                    new SqlParameter("@EvaluationAmount", SqlHelper.ToDbValue(data.PropertyEvaluation.EvaluationAmount)),
                    new SqlParameter("@PurchasePrice", SqlHelper.ToDbValue(data.PropertyEvaluation.PurchasePrice)),
                    new SqlParameter("@EvaluationDate", SqlHelper.ToDbValue(data.PropertyEvaluation.EvaluationDate)),
                    new SqlParameter("@EvaluatedBy", SqlHelper.ToDbValue(data.PropertyEvaluation.EvaluatedBy))
                );

                if (result != null && int.TryParse(result.ToString(), out int propertyID))
                    return propertyID;

                return -1;
            }
            catch (Exception ex)
            {
                _logger.LogError("Layer: DataAccess | Class: PropertyApplicationRepository | Method: Add", ex);
                return -1;
            }
        }
    }
}
