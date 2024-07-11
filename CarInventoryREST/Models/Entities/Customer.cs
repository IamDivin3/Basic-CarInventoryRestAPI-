namespace CarInventoryREST.Models.Entities
{
    public class Customer
    {
        public int CustomerId {  get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public string CustomerDescription { get; set; } = string.Empty;

        public string CustomerPhone { get; set; } = string.Empty;

        public string CustomerEmail { get; set; } = string.Empty;
    }
}
