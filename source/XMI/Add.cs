namespace XMI
{
    /// <summary>
    /// The Add class represents an addition to a target object in this document or
    /// other documents. The target is constrained to
    /// reference only one object. The position attribute indicates where to place the
    /// addition relative to other XML elements of
    /// that type within the target. The default, -1, indicates to add the new elements
    /// at the end of those elements for the target
    /// element. The addition attribute refers to the set of objects to be added. Both
    /// of these attributes have the tag
    /// org.omg.xmi.attribute set to “true.”
    /// </summary>
    public sealed class Add : Difference
    {
        public int Position { get; set; }
		
        public IList<string> Addition { get; set; }
    }
}