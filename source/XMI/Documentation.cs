namespace XMI
{
    /// <summary>
    /// The Documentation class contains information about the XMI document or stream
    /// being transmitted, for instance the
    /// owner of the document, a contact person for the document, long and short
    /// descriptions of the document, the exporter tool
    /// which created the document, the version of the tool, the date and time the
    /// document was created, and copyright or other
    /// legal notices regarding the document. The data type of all the attributes of
    /// Documentation is string except for the
    /// timestamp which is DateTime.
    /// </summary>
    public sealed class Documentation : IVisitable
    {
        public string? Contact { get; set; }

		public string? Exporter { get; set; }

        public string? ExporterVersion { get; set; }

        public string? ExporterID { get; set; }

        public string? LongDescription { get; set; }

        public string? ShortDescription { get; set; }

        public string? Notice { get; set; }

        public string? Owner { get; set; }

        public DateTime Timestamp { get; set; }

        public void Accept(IXmiVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}