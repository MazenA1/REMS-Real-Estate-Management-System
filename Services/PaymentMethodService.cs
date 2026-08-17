using Models;
using System.Collections.Generic;

public class PaymentMethodService : IPaymentMethodService
{
    private readonly IPaymentMethodRepository _repository;

    public PaymentMethodService(
        IPaymentMethodRepository repository)
    {
        _repository = repository;
    }

    private bool _AddPaymentMethod(
        PaymentMethod paymentMethod)
    {
        int id =
            _repository.Add(paymentMethod);

        if (id == -1)
            return false;

        paymentMethod.PaymentMethodID =
            (byte)id;

        return true;
    }

    private bool _UpdatePaymentMethod(
        PaymentMethod paymentMethod)
    {
        return _repository.Update(paymentMethod);
    }

    public bool Save(
        PaymentMethod paymentMethod)
    {
        if (paymentMethod == null)
            return false;

        switch (paymentMethod.Mode)
        {
            case PaymentMethod.enMode.AddNew:

                if (_AddPaymentMethod(paymentMethod))
                {
                    paymentMethod.Mode =
                        PaymentMethod.enMode.Update;

                    return true;
                }

                return false;

            case PaymentMethod.enMode.Update:

                return _UpdatePaymentMethod(
                    paymentMethod);
        }

        return false;
    }

    public bool Deactivate(
        byte paymentMethodID)
    {
        if (paymentMethodID <= 0)
            return false;

        return _repository.Deactivate(
            paymentMethodID);
    }

    public PaymentMethod GetByID(
        byte paymentMethodID)
    {
        if (paymentMethodID <= 0)
            return null;

        return _repository.GetByID(
            paymentMethodID);
    }

    public List<PaymentMethod> GetAll()
    {
        return _repository.GetAll();
    }

    public List<PaymentMethod> GetAllActive()
    {
        return _repository.GetAllActive();
    }

    public bool Exists(
        byte paymentMethodID)
    {
        if (paymentMethodID <= 0)
            return false;

        return _repository.Exists(
            paymentMethodID);
    }
}