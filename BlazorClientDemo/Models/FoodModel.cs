namespace BlazorClientDemo.Models
{
    public class FoodModel
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }


    }
}
