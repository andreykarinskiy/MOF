using MOF.ECore;

namespace XMI
{
    /// <summary>
    /// The Difference class is the superclass for the Add, Replace, and Delete classes.
    /// </summary>
    public abstract class Difference : IVisitable
    {
        /// <summary>
        /// MOF::EObject or UML::Element.
        /// </summary>
        public EObject? Target { get; set; }

        public Difference? Container { get; set; }
		
		public IList<Difference>? Differences { get; set; }

        public void Accept(IXmiVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}