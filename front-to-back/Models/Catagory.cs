namespace front_to_back.Models
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<CatagoryCompenent> catagoryComponents { get; set; }
    }
}
