namespace Desktop.Models.Data
{
    public class GitObjectModel
    {
        public string ShortSha => Sha.Substring(0, 8);
        public string Sha { get; set; }
    }
}
