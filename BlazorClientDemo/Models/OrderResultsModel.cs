namespace BlazorClientDemo.Models
{
    public class OrderResultsModel
    {
        public required OrderModel Order { get; set; }
        public required string ItemPurchased { get; set; }
    }
}
