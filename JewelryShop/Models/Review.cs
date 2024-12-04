namespace JewelryShop.Models
{
    public class Review
    {
        public int ID { get; set; }

        public int JewelryID { get; set; }
        public int CostumerID { get; set; }

        public string ReviewerName { get; set; }

        public int StarAmount { get; set; }
        public string Rewiew { get; set; }

        public Jewelry Jewelry { get; set; }
        public Costumer Costumer { get; set; }

    }
}
