using MOF.Common.Util;

namespace MOF.ECore
{
    /// <summary>
    /// A representation of the model object <b>EGeneric Type</b>.
    /// It can represent a reference to a type parameter, a reference to a classifier, 
    /// along with optional type arguments if the classifier specify type parameters,
    /// or a wildcard with an optional upper or lower bound.
    /// </summary>
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EGenericType.java
    public interface EGenericType : EObject
    {
        /// <summary>
        /// Returns the value of the <b>EUpper Bound</b> containment reference.
        /// </summary>
        /// <returns></returns>
        EGenericType GetEUpperBound();

        void SetEUpperBound(EGenericType value);

        /// <summary>
        /// Returns the value of the <b>EType Arguments</b> containment reference list.
        /// These represent the template arguments applied to a classifier with type parameters.
        /// </summary>
        EList<EGenericType> getETypeArguments();

        /**
         * 
         * <!-- begin-user-doc -->
         * <p>
         * This represents the erased or raw type of the generic type.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>ERaw Type</em>' reference.
         * @see org.eclipse.emf.ecore.EcorePackage#getEGenericType_ERawType()
         * @model required="true" transient="true" changeable="false" derived="true"
         * @generated
         */

        /// <summary>
        /// Returns the value of the '<em><b>ERaw Type</b></em>' reference.
        /// </summary>
        /// <returns></returns>
        EClassifier GetERawType();
        /**
         * Returns the value of the '<em><b>ELower Bound</b></em>' containment reference.
         * <!-- begin-user-doc -->
         * <p>
         * A generic type with a lower bound T, is equivalent to "? super T" in Java.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>ELower Bound</em>' containment reference.
         * @see #setELowerBound(EGenericType)
         * @see org.eclipse.emf.ecore.EcorePackage#getEGenericType_ELowerBound()
         * @model containment="true"
         * @generated
         */
        EGenericType GetELowerBound();
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EGenericType#getELowerBound <em>ELower Bound</em>}' containment reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>ELower Bound</em>' containment reference.
         * @see #getELowerBound()
         * @generated
         */
        void SetELowerBound(EGenericType value);
        /**
         * Returns the value of the '<em><b>EType Parameter</b></em>' reference.
         * <!-- begin-user-doc -->
         * <p>
         * The represents a reference to a type parameter.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>EType Parameter</em>' reference.
         * @see #setETypeParameter(ETypeParameter)
         * @see org.eclipse.emf.ecore.EcorePackage#getEGenericType_ETypeParameter()
         * @model resolveProxies="false"
         * @generated
         */
        ETypeParameter GetETypeParameter();
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EGenericType#getETypeParameter <em>EType Parameter</em>}' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>EType Parameter</em>' reference.
         * @see #getETypeParameter()
         * @generated
         */
        void SetETypeParameter(ETypeParameter value);
        /**
         * Returns the value of the '<em><b>EClassifier</b></em>' reference.
         * <!-- begin-user-doc -->
         * <p>
         * The represents a reference to a classifier.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>EClassifier</em>' reference.
         * @see #setEClassifier(EClassifier)
         * @see org.eclipse.emf.ecore.EcorePackage#getEGenericType_EClassifier()
         * @model
         * @generated
         */
        EClassifier getEClassifier();
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EGenericType#getEClassifier <em>EClassifier</em>}' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>EClassifier</em>' reference.
         * @see #getEClassifier()
         * @generated
         */
        void setEClassifier(EClassifier value);
        /**
         * <!-- begin-user-doc -->
         * Returns whether the object is an instance of this generic type.
         * @since 2.9
         * <!-- end-user-doc -->
         * @model
         * @generated
         */
        bool IsInstance(object reference);
    }
}
