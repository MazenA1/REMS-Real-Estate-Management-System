using Interfaces;
using Models.Entities;
using Models.FormData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
public class InvestorRegistrationRepository
    : IInvestorRegistrationRepository
{
    private readonly IAppLogger _logger;


    public InvestorRegistrationRepository(
        IAppLogger logger)
    {
        _logger = logger;
    }


    public bool Register(
        InvestorRegistrationData data)
    {
        try
        {
            DataTable preferredCitiesTable =
                _CreatePreferredCitiesTable(
                    data.PreferredCityIDs);

            DataTable preferredPropertyTypesTable =
                _CreatePreferredPropertyTypesTable(
                    data.PreferredPropertyTypeIDs);


            SqlParameter preferredCitiesParameter =
                new SqlParameter(
                    "@PreferredCities",
                    preferredCitiesTable);

            preferredCitiesParameter.SqlDbType =
                SqlDbType.Structured;

            preferredCitiesParameter.TypeName =
                "dbo.InvestorPreferredCityTableType";



            SqlParameter preferredPropertyTypesParameter =
                new SqlParameter(
                    "@PreferredPropertyTypes",
                    preferredPropertyTypesTable);

            preferredPropertyTypesParameter.SqlDbType =
                SqlDbType.Structured;

            preferredPropertyTypesParameter.TypeName =
                "dbo.InvestorPreferredPropertyTypeTableType";


            SqlParameter[] parameters =
            {
                // ClientRole
                new SqlParameter(
                    "@ClientID",
                    data.ClientRole.ClientID),

                new SqlParameter(
                    "@ClientRoleTypeID",
                    data.ClientRole.ClientRoleTypeID),

                new SqlParameter(
                    "@CreatedByUserID",
                    data.Investor.CreatedByUserID),

                new SqlParameter(
                    "@Notes",
                    Helpers.SqlHelper.ToDbValue(
                        data.Investor.Notes)),


                // Investor
                new SqlParameter(
                    "@MinimumBudget",
                    Helpers.SqlHelper.ToDbValue(
                        Convert.ToDecimal(data.Investor.MinimumBudget))),

                new SqlParameter(
                    "@MaximumBudget",
                    Helpers.SqlHelper.ToDbValue(
                        Convert.ToDecimal(data.Investor.MaximumBudget))),

                new SqlParameter(
                    "@PaymentMethodID",
                    data.Investor.PaymentMethodID),

                new SqlParameter(
                    "@InvestmentPurposeID",
                    data.Investor.InvestmentPurposeID),

                new SqlParameter(
                    "@InterestLevelID",
                    data.Investor.InterestLevelID),

                new SqlParameter(
                    "@OpeningBalance",
                    Helpers.SqlHelper.ToDbValue(
                        Convert.ToDecimal(data.Investor.OpeningBalance))),

                new SqlParameter(
                    "@ReadyToInvest",
                    data.Investor.ReadyToInvest),

                new SqlParameter(
                    "@RepresentativeName",
                    Helpers.SqlHelper.ToDbValue(
                        data.Investor.RepresentativeName)),

                new SqlParameter(
                    "@RepresentativeNationalID",
                    Helpers.SqlHelper.ToDbValue(
                        data.Investor.RepresentativeNationalID)),

                new SqlParameter(
                    "@AgencyNumber",
                    Helpers.SqlHelper.ToDbValue(
                        data.Investor.AgencyNumber)),

                new SqlParameter(
                    "@AgencyDate",
                    Helpers.SqlHelper.ToDbValue(
                        Convert.ToDateTime(data.Investor.AgencyDate))),


                // TVPs
                preferredCitiesParameter,

                preferredPropertyTypesParameter
            };


            DataTable result =
                Helpers.SqlHelper.ExecuteDataTable(
                    "SP_RegisterInvestor",
                    parameters);


            if (result == null ||
                result.Rows.Count == 0)
            {
                return false;
            }


            DataRow row = result.Rows[0];


            data.Investor.InvestorID =
                Convert.ToInt32(
                    row["InvestorID"]);


            data.ClientRole.ClientRoleID =
                Convert.ToInt32(
                    row["ClientRoleID"]);


            data.Investor.ClientRoleID =
                data.ClientRole.ClientRoleID;


            data.Investor.Mode =
                Investor.enMode.Update;


            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"Layer: DataAccess | " +
                $"Class: InvestorRegistrationRepository | " +
                $"Method: Register | " +
                $"Exception: {ex}");

            return false;
        }
    }

    private DataTable _CreatePreferredCitiesTable(
    IEnumerable<short> cityIDs) 
    {
        DataTable table =
            new DataTable();

        table.Columns.Add(
            "CityID",
            typeof(int));


        if (cityIDs == null)
            return table;


        foreach (int cityID in cityIDs.Distinct())
        {
            table.Rows.Add(cityID);
        }


        return table;
    }


    private DataTable _CreatePreferredPropertyTypesTable(
        IEnumerable<short> propertyTypeIDs)
    {
        DataTable table =
            new DataTable();

        table.Columns.Add(
            "PropertyTypeID",
            typeof(int));


        if (propertyTypeIDs == null)
            return table;


        foreach (
            int propertyTypeID
            in propertyTypeIDs.Distinct())
        {
            table.Rows.Add(
                propertyTypeID);
        }


        return table;
    }
}