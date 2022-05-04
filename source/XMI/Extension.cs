namespace XMI
{
    /// <summary>
    /// The Extension class is designed to contain extended information outside the
    /// scope of the user model. Extensions are a
    /// multivalued attribute of the XMI class and may also be embedded in specific
    /// locations in an XMI document.
    /// </summary>
    public sealed class Extension : IVisitable
    {
        public string Extender { get; set; }

		public string ExtenderID { get; set; }

        public void Accept(IXmiVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}