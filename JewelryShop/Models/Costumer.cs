namespace JewelryShop.Models
{
    public class Costumer
    {
        public int CostumerID { get; set; }
        public string CostumerName { get; set; }

        public string CostumerGmail { get; set; }

        public ICollection<Review> Reviews { get; set; }

    }
}
