using System;

namespace Desktop.Models.Data
{
    public class SignatureModel
    {
        public string Name { get; set; }
        public DateTimeOffset When { get; set; }
        public string FormattedWhen => When.ToString("g");
    }
}
