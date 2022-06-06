namespace XMI
{
    /// <summary>
    /// The root level XML element for XMI documents containing only XMI data may be
    /// the XMI element, but it must be the
    /// XMI element if there are multiple elements.
    /// </summary>
    public sealed class XMI : IVisitable
    {
        public Documentation? Documentation { get; set; }
		
        public IList<Difference>? Difference { get; set; }

		public IList<Extension>? Extension { get; set; }

        public void Accept(IXmiVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}