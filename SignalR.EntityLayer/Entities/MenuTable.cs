namespace SignalR.EntityLayer.Entities
{
    public class MenuTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public List<Basket> Baskets { get; set; }
    }
}
