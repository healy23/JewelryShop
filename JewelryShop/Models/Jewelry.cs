namespace JewelryShop.Models
{
    public class Jewelry
    {
        public int JewelryID { get; set; }
        public string JeweleryName { get; set; }

        public string Material { get; set; }

        public int CostumerID { get; set; }
        public Costumer CostumerI{ get; set; }
        public string ReviewID { get; set; }
        public Review Review { get; set; }

        public ICollection<Review> Reviews { get; set; }

    }
}
