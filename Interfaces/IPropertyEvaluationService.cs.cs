using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IPropertyEvaluationService
    {
        bool Save(PropertyEvaluation evaluation);
        bool Delete(int propertyEvaluationID);

        PropertyEvaluation GetByID(int propertyEvaluationID);
        PropertyEvaluation GetLastByPropertyID(int propertyID);

        List<PropertyEvaluation> GetByPropertyID(int propertyID);
        List<PropertyEvaluation> GetAll();

        bool Exists(int propertyEvaluationID);
    }
}