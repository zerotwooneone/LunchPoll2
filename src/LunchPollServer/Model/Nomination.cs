namespace LunchPollApi.Model
{
    public class Nomination
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Approves { get; set; }
        public int Vetoes { get; set; }
    }
}
