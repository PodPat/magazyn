namespace magazyn_v1.Models
{
    namespace magazyn_v1.Models
    {
        public class Order
        {
            public int Id { get; set; }
            public string CustomerFirstName { get; set; }
            public string CustomerLastName { get; set; }
            public string CustomerEmail { get; set; }
            public string CustomerPhone { get; set; }
            public string CustomerAdress { get; set; }
            public int Qty { get; set; }
            public string product { get; set; }
        }
    }
}
