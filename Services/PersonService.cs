using Interfaces;
using Models;
using System.Collections.Generic;
using System.Data;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    private bool _AddPerson(Person person)  
    {
        int personID = _personRepository.Add(person);

        if (personID != -1)
        {
            person.PersonID = personID;
            return true;
        }

        return false; 
    }

    private bool _UpdatePerson(Person person) 
    {
        return _personRepository.Update(person);
    }

    public bool Save(Person person)
    {
        switch (person.Mode)
        {
            case Person.enMode.AddNew:
                if (_AddPerson(person))
                {
                    person.Mode = Person.enMode.Update;
                    return true;
                }
                else
                    return false;

            case Person.enMode.Update:
                return _UpdatePerson(person);
        }

        return false;   
    }

    public bool Delete(int personID)
    {
        return _personRepository.Delete(personID);
    }

    public Person FindByID(int personID)
    {
        return _personRepository.GetByID(personID);
    }
    public Person FindByNationalNo(string NationalNo)
    {
        return _personRepository.GetByNationalNo(NationalNo);
    }
    public List<Person> GetAll()
    {
        return _personRepository.GetAll();
    }

    public bool Exists(int personID)
    {
        return _personRepository.Exists(personID);
    }

    public bool ExistsByNationalNo(string nationalNo)
    {
        return _personRepository.ExistsByNationalNo(nationalNo);
    }
}