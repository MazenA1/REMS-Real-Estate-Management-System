using Models;
using System.Collections.Generic;

public interface IPaymentMethodService
{
    bool Save(PaymentMethod paymentMethod);

    bool Deactivate(byte paymentMethodID);

    PaymentMethod GetByID(byte paymentMethodID);

    List<PaymentMethod> GetAll();

    List<PaymentMethod> GetAllActive();

    bool Exists(byte paymentMethodID);
}