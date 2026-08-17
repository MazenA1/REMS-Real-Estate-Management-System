using Models;
using System.Collections.Generic;

public interface IPaymentMethodRepository
{
    int Add(PaymentMethod paymentMethod);

    bool Update(PaymentMethod paymentMethod);

    bool Deactivate(byte paymentMethodID);

    PaymentMethod GetByID(byte paymentMethodID);

    List<PaymentMethod> GetAll();

    List<PaymentMethod> GetAllActive();

    bool Exists(byte paymentMethodID);
}