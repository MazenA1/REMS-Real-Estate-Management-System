using Helpers;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
public class PersonRepository : IPersonRepository
{
    private readonly IAppLogger _loggerService; 
    public PersonRepository(IAppLogger appLogger)
    {
        this._loggerService = appLogger; 
    }
    public int Add(Person person)
    {

        try
        {
            object result = SqlHelper.ExecuteScalar(
                "SP_AddNewPerson",
                new SqlParameter("@FullName", person.FullName),
                new SqlParameter("@NationalNo", person.NationalNo),
                new SqlParameter("@PhoneNumber", person.PhoneNumber),
                new SqlParameter("@TaxNumber", SqlHelper.ToDbValue(person.TaxNumber)),
                new SqlParameter("@AnotherPhone", SqlHelper.ToDbValue(person.AnotherPhone)),
                new SqlParameter("@Email", SqlHelper.ToDbValue(person.Email)),
                new SqlParameter("@DateOfBirth", person.DateOfBirth),
                new SqlParameter("@Gendor", person.Gendor),
                new SqlParameter("@NameEnglish", SqlHelper.ToDbValue(person.NameEnglish)),
                new SqlParameter("@NationalityCountryID", person.NationalityCountryID),
                new SqlParameter("@ImagePath", SqlHelper.ToDbValue(person.ImagePath)),
                new SqlParameter("@IdPhotoPath", SqlHelper.ToDbValue(person.IdPhotoPath))
            );

            return (result != null && int.TryParse(result.ToString(), out int personID))
                ? personID
                : -1;
        }
        catch (Exception ex)
        {
            _loggerService.LogError("Layer: DataAccess | Class: PersonRepository | Method: Add ", ex);
            return -1;
        }
    }

    public bool Update(Person person)
    {
        try
        {
            int rowsAffected = SqlHelper.ExecuteNonQuery(
                "SP_UpdatePerson",
                new SqlParameter("@PersonID", person.PersonID),
                new SqlParameter("@FullName", person.FullName),
                new SqlParameter("@NationalNo", person.NationalNo),
                new SqlParameter("@PhoneNumber", person.PhoneNumber),
                new SqlParameter("@TaxNumber", SqlHelper.ToDbValue(person.TaxNumber)),
                new SqlParameter("@AnotherPhone", SqlHelper.ToDbValue(person.AnotherPhone)),
                new SqlParameter("@Email", SqlHelper.ToDbValue(person.Email)),
                new SqlParameter("@DateOfBirth", person.DateOfBirth),
                new SqlParameter("@Gendor", person.Gendor),
                new SqlParameter("@NameEnglish", SqlHelper.ToDbValue(person.NameEnglish)),
                new SqlParameter("@NationalityCountryID", person.NationalityCountryID),
                new SqlParameter("@ImagePath", SqlHelper.ToDbValue(person.ImagePath)),
                new SqlParameter("@IdPhotoPath", SqlHelper.ToDbValue(person.IdPhotoPath))
            );

            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            _loggerService.LogError("Layer: DataAccess | Class: PersonRepository | Method: Update ", ex);

            return false;
        }
    }

    public bool Delete(int personID)
    {
        try
        {
            int rowsAffected = SqlHelper.ExecuteNonQuery(
                "SP_DeletePerson",
                new SqlParameter("@PersonID", personID)
            );

            return rowsAffected > 0;
        }
        catch (SqlException ex)
        {
            _loggerService.LogError("Layer: DataAccess | Class: PersonRepository | Method: Delete ", ex);

            return false;
        }
    }

    public Person GetByID(int personID)
    {
        Person person = null;
        try
        {
            using (SqlDataReader reader = SqlHelper.ExecuteReader(
                "SP_GetPersonByID",
                new SqlParameter("@PersonID", personID)))
            {
                if (reader.Read())
                {
                    person = new Person
                    {
                        PersonID = (int)reader["PersonID"],
                        FullName = reader["FullName"].ToString(),
                        NationalNo = reader["NationalNo"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        TaxNumber = reader["TaxNumber"] == DBNull.Value ? "" : reader["TaxNumber"].ToString(),
                        AnotherPhone = reader["AnotherPhone"] == DBNull.Value ? "" : reader["AnotherPhone"].ToString(),
                        Email = reader["Email"] == DBNull.Value ? "" : reader["Email"].ToString(),
                        DateOfBirth = (DateTime)reader["DateOfBirth"],
                        Gendor = Convert.ToByte(reader["Gendor"]),
                        NameEnglish = reader["NameEnglish"] == DBNull.Value ? "" : reader["NameEnglish"].ToString(),
                        NationalityCountryID = (int)reader["NationalityCountryID"],
                        ImagePath = reader["ImagePath"] == DBNull.Value ? "" : reader["ImagePath"].ToString(),
                        IdPhotoPath = reader["IdPhotoPath"] == DBNull.Value ? "" : reader["IdPhotoPath"].ToString()
                    };
                }
            }

            return person;
        }
        catch (Exception ex)
        {
            _loggerService.LogError("Layer: DataAccess | Class: PersonRepository | Method: GetByID ", ex); 

            return null;
        }
    }

    public Person GetByNationalNo(string nationalNo)
    {
        Person person = null;

        try
        {
            using (SqlDataReader reader = SqlHelper.ExecuteReader(
                "SP_GetPersonByNationalNo",
                new SqlParameter("@NationalNo", nationalNo)))
            {
                if (reader.Read())
                {
                    person = new Person
                    {
                        PersonID = (int)reader["PersonID"],
                        FullName = reader["FullName"].ToString(),
                        NationalNo = reader["NationalNo"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        TaxNumber = reader["TaxNumber"] == DBNull.Value ? "" : reader["TaxNumber"].ToString(),
                        AnotherPhone = reader["AnotherPhone"] == DBNull.Value ? "" : reader["AnotherPhone"].ToString(),
                        Email = reader["Email"] == DBNull.Value ? "" : reader["Email"].ToString(),
                        DateOfBirth = (DateTime)reader["DateOfBirth"],
                        Gendor = Convert.ToByte(reader["Gendor"]),
                        NameEnglish = reader["NameEnglish"] == DBNull.Value ? "" : reader["NameEnglish"].ToString(),
                        NationalityCountryID = (int)reader["NationalityCountryID"],
                        ImagePath = reader["ImagePath"] == DBNull.Value ? "" : reader["ImagePath"].ToString(),
                        IdPhotoPath = reader["IdPhotoPath"] == DBNull.Value ? "" : reader["IdPhotoPath"].ToString(),
                        Mode = Person.enMode.Update
                    };
                }
            }

            return person;
        }
        catch
        {
            return null;
        }
    }
    public List<Person> GetAll()
    {
        List<Person> list = new List<Person>();

        try
        {
            using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllPeople"))
            {
                while (reader.Read())
                {
                    Person person = new Person
                    {
                        PersonID = (int)reader["PersonID"],
                        FullName = reader["FullName"].ToString(),
                        NationalNo = reader["NationalNo"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        TaxNumber = reader["TaxNumber"] == DBNull.Value ? "" : reader["TaxNumber"].ToString(),
                        AnotherPhone = reader["AnotherPhone"] == DBNull.Value ? "" : reader["AnotherPhone"].ToString(),
                        Email = reader["Email"] == DBNull.Value ? "" : reader["Email"].ToString(),
                        DateOfBirth = (DateTime)reader["DateOfBirth"],
                        Gendor = Convert.ToByte(reader["Gendor"]),
                        NameEnglish = reader["NameEnglish"] == DBNull.Value ? "" : reader["NameEnglish"].ToString(),
                        NationalityCountryID = (int)reader["NationalityCountryID"],
                        ImagePath = reader["ImagePath"] == DBNull.Value ? "" : reader["ImagePath"].ToString(),
                        IdPhotoPath = reader["IdPhotoPath"] == DBNull.Value ? "" : reader["IdPhotoPath"].ToString()
                    };

                    list.Add(person);
                }
            }
            return list;    
        }
        catch (Exception ex)
        {
            _loggerService.LogError("Layer: DataAccess | Class: PersonRepository | Method: GetAll ", ex);

            return null;
        }
    }

    public bool Exists(int personID)
    {
        try
        {
            object result = SqlHelper.ExecuteScalar(
                "SP_IsPersonExist",
                new SqlParameter("@PersonID", personID)
            );

            return result != null && Convert.ToInt32(result) == 1;
        }
        catch (SqlException ex)
        {
            _loggerService.LogError("Layer: DataAccess | Class: PersonRepository | Method: Exists ", ex);

            return false;
        }
    }

    public bool ExistsByNationalNo(string nationalNo)
    {
        try
        {
            object result = SqlHelper.ExecuteScalar(
                "SP_IsPersonExistByNationalNo",
                new SqlParameter("@NationalNo", nationalNo)
            );

            return result != null && Convert.ToInt32(result) == 1;
        }
        catch (Exception ex)
        {
            _loggerService.LogError("Layer: DataAccess | Class: PersonRepository | Method: ExistsByNationalNo ", ex);

            return false;
        }
    }
}