using System.Data.SqlTypes;

namespace Core.Entities.OrderAggregate
{
    public class ProductItemOrdered
    {
        public ProductItemOrdered () {}
        public ProductItemOrdered (
             int ProductItemId, string productName, string pictureUrl)
        {
            ProductItemId = ProductItemId;
            ProductName = productName;
            pictureUrl = pictureUrl;
        }

        public int ProductItemId { get; set; }
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
    }
}