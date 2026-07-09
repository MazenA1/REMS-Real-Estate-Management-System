using Interfaces;
using Models;
using System.Collections.Generic;

namespace Services
{
    public class PropertyEvaluationService : IPropertyEvaluationService
    {
        private readonly IPropertyEvaluationRepository _repository;

        public PropertyEvaluationService(IPropertyEvaluationRepository repository)
        {
            _repository = repository;
        }

        private bool _Add(PropertyEvaluation evaluation)
        {
            int id = _repository.Add(evaluation);

            if (id != -1)
            {
                evaluation.PropertyEvaluationID = id;
                evaluation.Mode = PropertyEvaluation.enMode.Update;
                return true;
            }

            return false;
        }

        private bool _Update(PropertyEvaluation evaluation)
        {
            return _repository.Update(evaluation);
        }

        public bool Save(PropertyEvaluation evaluation)
        {
            if (evaluation == null)
                return false;

            switch (evaluation.Mode)
            {
                case PropertyEvaluation.enMode.AddNew:
                    return _Add(evaluation);

                case PropertyEvaluation.enMode.Update:
                    return _Update(evaluation);
            }

            return false;
        }

        public bool Delete(int propertyEvaluationID)
        {
            return _repository.Delete(propertyEvaluationID);
        }

        public PropertyEvaluation GetByID(int propertyEvaluationID)
        {
            return _repository.GetByID(propertyEvaluationID);
        }

        public PropertyEvaluation GetLastByPropertyID(int propertyID)
        {
            return _repository.GetLastByPropertyID(propertyID);
        }

        public List<PropertyEvaluation> GetByPropertyID(int propertyID)
        {
            return _repository.GetByPropertyID(propertyID);
        }

        public List<PropertyEvaluation> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Exists(int propertyEvaluationID)
        {
            return _repository.Exists(propertyEvaluationID);
        }
    }
}