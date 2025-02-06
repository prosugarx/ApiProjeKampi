namespace ApiProjeKampi.WebApi.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MesaageDetails { get; set; }
        public DateTime SendTime { get; set; }
        public bool Status { get; set; }
    }
}
