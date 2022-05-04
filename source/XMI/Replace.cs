namespace XMI
{
    /// <summary>
    /// The Replace class represents the removal of a target set of objects and the
    /// addition of the objects referred to in the
    /// replacement attribute. The position attribute indicates where to place the
    /// replacements relative to other XML elements of
    /// that type within their container (they should all be of the same XML type). The
    /// default, -1, indicates to add the new
    /// elements at the end of those elements for the target element. The replacement
    /// attribute refers to the objects that will
    /// replace the target elements. Both of these attributes have the tag org.omg.xmi.
    /// attribute set to “true.” Note that, unlike Delete, the replaced elements are 
    /// only removed from the container not deleted.
    /// </summary>
    public sealed class Replace : Difference
    {
        public int Position { get; set; }

		public IList<string> Replacement { get; set; }
    }
}