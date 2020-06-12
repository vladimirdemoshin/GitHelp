namespace Desktop.Models.Data
{
    public class CommitModel : GitObjectModel
    {
        public string Message { get; set; }
        public SignatureModel Author { get; set; }
    }
}
