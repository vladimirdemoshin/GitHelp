namespace Domain.Data
{
    public class Commit : GitObject
    {
        public string Message { get; set; }
        public Signature Author { get; set; }
        public Signature Committer { get; set; }
    }
}
