namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EPackage : ENamedElement
    {
        /// <summary>
        /// It represents the namespace URI, i.e., a universally unique 
        /// identification of a particular package, much like an XML Schema target namespace. 
        /// It will be used in an XMI serialization. 
        /// It is typically registered with the global package registry.
        /// </summary>
        string NsURI { get; set; }

        /// <summary>
        /// It represents the preferred XMLNS prefix to be used for this package's the namespace URI. 
        /// It will be used in an XMI serialization.
        /// </summary>
        string NsPrefix { get; set; }

        /// <summary>
        /// It this package's factory for creating modeled object instances.
        /// </summary>
        EFactory? EFactoryInstance { get; }

        /// <summary>
        /// It is bidirectional and its opposite is EPackage.
        /// It represents the meta objects, i.e., classes and data types, defined in this package.
        /// </summary>
        IList<EClassifier> EClassifiers { get; }

        /// <summary>
        /// It is bidirectional and its opposite is ESuper Package.
        /// It represents the nested packages contained by this package.
        /// </summary>
        IList<EPackage> ESubpackages { get; }

        /// <summary>
        /// It is bidirectional and its opposite is ESubpackages.
        /// It represents the containing package of this package.
        /// </summary>
        EPackage? ESuperPackage { get; internal set; }

        /// <summary>
        /// Returns the classifier with the given name.
        /// </summary>
        EClassifier GetEClassifier(string name);
    }
}
