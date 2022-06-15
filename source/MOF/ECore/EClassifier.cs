namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EClassifier : ENamedElement
    {
        /// <summary>
        /// It represents the name of the C# instance class that this meta object represents.
        /// </summary>
        string InstanceClassName { get; set; }

        /// <summary>
        /// It represents the actual Java instance class that this meta object represents.
        /// </summary>
        Type InstanceClass { get; set; }

        /// <summary>
        /// The default value for the type, in the Java sense. 
        /// For primitive types, it will be the C# primitive default wrapped appropriately. 
        /// For enums, it will be the first enumerator. 
        /// And for all other types derived from System.Object, it will be null.
        /// </summary>
        object DefaultValue { get; }

        /// <summary>
        /// It represents the parameterized C# type that this meta object represents.
        /// </summary>
        string InstanceTypeName { get; set; }

        /// <summary>
        /// Returns the value of the EPackage container reference. 
        /// It is bidirectional and its opposite is EClassifiers.
        /// </summary>
        EPackage EPackage { get; set; }

        /// <summary>
        /// A classifier can optionally introduce type parameters.
        /// </summary>
        IList<ETypeParameter> ETypeParameters { get; }

        /// <summary>
        /// Returns whether the object is an instance of this classifier.
        /// </summary>
        bool IsInstance(object instance);

        /// <summary>
        /// Returns the ID relative to the containing package.
        /// </summary>
        int ClassifierID { get; }
    }
}
