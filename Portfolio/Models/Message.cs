namespace Portfolio.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DateSent { get; set; }
        public string EmailAddress { get; set; }
    }
}
