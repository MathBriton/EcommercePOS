using Core.Entities.OrderAggregate;

namespace Core.Specifications
{
    public class OrderByPaymentIntentIdSpecification : BaseSpecification<Order>
    {
        public OrderByPaymentIntentSpecification(string paymentIntentId) : base( o=> o.PaymentIntentId == paymentIntentId) {}
    }
}