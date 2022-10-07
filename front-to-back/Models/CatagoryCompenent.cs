namespace front_to_back.Models
{
    public class CatagoryCompenent
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public Catagory catagory { get; set; }
        public int CatagoryId { get; set; }
    }
}
