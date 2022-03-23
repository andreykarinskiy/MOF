using MOF.Common.Util;

namespace MOF.ECore
{
    /// <summary>
    /// A representation of the model object EClassifier.
    /// </summary>
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EClassifier.java
    public interface EClassifier : ENamedElement
    {
        /// <summary>
        /// Returns the value of the Instance Class Name attribute.
        /// </summary>
        string GetInstanceClassName();

        /// <summary>
        ///  Sets the value of the Instance Class Name attribute.
        /// </summary>
        /// <param name="value"></param>
        void SetInstanceClassName(string value);

        /// <summary>
        /// Returns the value of the Instance Class attribute.
        /// It represents the actual C# instance class that this meta object represents.
        /// </summary>
        /// <returns></returns>
        object GetInstanceClass();

        void SetInstanceClass(object value);

        /**
         * 
         * <!-- begin-user-doc -->
         * <p>
         * The default value for the type, in the Java sense.
         * For primitive types, it will be the Java primitive default wrapped appropriately.
         * For {@link EEnum enums}, it will be the first enumerator.
         * And for all other types derived from <code>java.lang.Object</code>, it will be null.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>Default Value</em>' attribute.
         * @see org.eclipse.emf.ecore.EcorePackage#getEClassifier_DefaultValue()
         * @model transient="true" changeable="false" volatile="true" derived="true"
         * @generated
         */

        /// <summary>
        /// Returns the value of the Default Value attribute.
        /// The default value for the type, in the C# sense.
        /// For primitive types, it will be the C# primitive default wrapped appropriately.
        /// For EEnum enums, it will be the first enumerator.
        /// And for all other types derived from Object, it will be null.
        /// </summary>
        object GetDefaultValue();

        /// <summary>
        /// Returns the value of the Instance Type Name attribute.
        /// It represents the parameterized C# type that this meta object represents.
        /// </summary>
        string GetInstanceTypeName();

        void SetInstanceTypeName(string value);

        /// <summary>
        /// Returns the value of the EPackage container reference.
        /// </summary>
        /// <returns></returns>
        EPackage GetEPackage();

        /// <summary>
        /// Returns the value of the EType Parameters containment reference list.
        /// </summary>
        /// <returns></returns>
        EList<ETypeParameter> GetETypeParameters();

        /// <summary>
        /// Returns whether the object is an instance of this classifier.
        /// </summary>
        bool IsInstance(object reference);

        /// <summary>
        /// Returns the ID relative to the EPackage containing package.
        /// </summary>
        int GetClassifierID();
    }
}