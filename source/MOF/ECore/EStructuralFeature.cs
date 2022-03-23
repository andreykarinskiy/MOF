using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EStructuralFeature.java
    public interface EStructuralFeature : ETypedElement
    {
        /**
   * Returns the value of the '<em><b>Transient</b></em>' attribute.
   * <!-- begin-user-doc -->
   * <!-- end-user-doc -->
   * @return the value of the '<em>Transient</em>' attribute.
   * @see #setTransient(boolean)
   * @see org.eclipse.emf.ecore.EcorePackage#getEStructuralFeature_Transient()
   * @model
   * @generated
   */
        bool isTransient();
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EStructuralFeature#isTransient <em>Transient</em>}' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>Transient</em>' attribute.
         * @see #isTransient()
         * @generated
         */
        void setTransient(bool value);
        /**
         * Returns the value of the '<em><b>Volatile</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the value of the '<em>Volatile</em>' attribute.
         * @see #setVolatile(boolean)
         * @see org.eclipse.emf.ecore.EcorePackage#getEStructuralFeature_Volatile()
         * @model
         * @generated
         */
        bool isVolatile();
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EStructuralFeature#isVolatile <em>Volatile</em>}' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>Volatile</em>' attribute.
         * @see #isVolatile()
         * @generated
         */
        void setVolatile(bool value);
        /**
         * Returns the value of the '<em><b>Changeable</b></em>' attribute.
         * The default value is <code>"true"</code>.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the value of the '<em>Changeable</em>' attribute.
         * @see #setChangeable(boolean)
         * @see org.eclipse.emf.ecore.EcorePackage#getEStructuralFeature_Changeable()
         * @model default="true"
         * @generated
         */
        bool isChangeable();
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EStructuralFeature#isChangeable <em>Changeable</em>}' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>Changeable</em>' attribute.
         * @see #isChangeable()
         * @generated
         */
        void setChangeable(bool value);
        /**
         * Returns the value of the '<em><b>Default Value Literal</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <p>
         * It represents the serialized form of the default value.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>Default Value Literal</em>' attribute.
         * @see #setDefaultValueLiteral(String)
         * @see org.eclipse.emf.ecore.EcorePackage#getEStructuralFeature_DefaultValueLiteral()
         * @model
         * @generated
         */
        string getDefaultValueLiteral();
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EStructuralFeature#getDefaultValueLiteral <em>Default Value Literal</em>}' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>Default Value Literal</em>' attribute.
         * @see #getDefaultValueLiteral()
         * @generated
         */
        void setDefaultValueLiteral(string value);
        /**
         * Returns the value of the '<em><b>Default Value</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <p>
         * It represents the default value that feature must take on when an
         * explicit value has not been set.  Specifically, it may be non-null if
         * the feature has an {@link ETypedElement#getEType eType}.  If the
         * {@link #getDefaultValueLiteral defaultValueLiteral} is null, it is
         * simply the <code>eType</code>'s intrinsic {@link
         * EClassifier#getDefaultValue default value}.  Otherwise, if the 
         * <code>eType</code> is an {@link EDataType} and the
         * <code>defaultValueLiteral</code> is non-null, it is the object created
         * by the factory's {@link EFactory#createFromString} method when invoked
         * with those two objects as parameters.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>Default Value</em>' attribute.
         * @see org.eclipse.emf.ecore.EcorePackage#getEStructuralFeature_DefaultValue()
         * @model transient="true" changeable="false" volatile="true" derived="true"
         * @generated
         */
        object getDefaultValue();
        /**
         * A convenience method for setting the '<em><b>Default Value Literal</b></em>' attribute.
         * <p>
         * If the feature has an {@link ETypedElement#getEType eType} that is an
         * {@link EDataType}, the specified <code>value</code> is converted to
         * a string using the factory's {@link EFactory#convertToString} 
         * method, and the {@link #getDefaultValueLiteral defaultValueLiteral} is
         * set to the result.
         * </p>
         * @see #setDefaultValueLiteral
         */
        void setDefaultValue(object value);
        /**
         * Returns the value of the '<em><b>Unsettable</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <p>
         * An unsettable feature explicitly models the state of being set verses being unset
         * and so provides a direct implementation for the reflective {@link EObject#eIsSet eIsSet}.
         * It is only applicable {@link ETypedElement#isMany single-valued} features.
         * One effect of this setting is that,
         * in addition to generating the methods <code>getXyz</code>
         * and <code>setXyz</code> (if the feature is {@link #isChangeable changeable}),
         * a reflective generator will generate the methods <code>isSetXyz</code> and <code>unsetXyz</code>.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>Unsettable</em>' attribute.
         * @see #setUnsettable(boolean)
         * @see org.eclipse.emf.ecore.EcorePackage#getEStructuralFeature_Unsettable()
         * @model
         * @generated
         */
        bool isUnsettable();
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EStructuralFeature#isUnsettable <em>Unsettable</em>}' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>Unsettable</em>' attribute.
         * @see #isUnsettable()
         * @generated
         */
        void setUnsettable(bool value);
        /**
         * Returns the value of the '<em><b>Derived</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <p>
         * A derived feature typically computes its value from those of other features.
         * It will typically be {@link #isTransient transient} 
         * and will often be {@link #isVolatile volatile} and not {@link #isChangeable changeable}.
         * The default {@link org.eclipse.emf.ecore.util.EcoreUtil.Copier copier} won't copy it.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>Derived</em>' attribute.
         * @see #setDerived(boolean)
         * @see org.eclipse.emf.ecore.EcorePackage#getEStructuralFeature_Derived()
         * @model
         * @generated
         */
        bool isDerived();
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EStructuralFeature#isDerived <em>Derived</em>}' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>Derived</em>' attribute.
         * @see #isDerived()
         * @generated
         */
        void setDerived(bool value);
        /**
         * Returns the value of the '<em><b>EContaining Class</b></em>' container reference.
         * It is bidirectional and its opposite is '{@link org.eclipse.emf.ecore.EClass#getEStructuralFeatures <em>EStructural Features</em>}'.
         * <!-- begin-user-doc -->
         * <p>
         * It represents the containing class of this feature.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>EContaining Class</em>' container reference.
         * @see org.eclipse.emf.ecore.EcorePackage#getEStructuralFeature_EContainingClass()
         * @see org.eclipse.emf.ecore.EClass#getEStructuralFeatures
         * @model opposite="eStructuralFeatures" resolveProxies="false" changeable="false"
         * @generated
         */
        EClass getEContainingClass();
        /**
         * <!-- begin-user-doc -->
         * Returns the ID relative to the {@link #getEContainingClass containing} class.
         * @return  the relative ID.
         * <!-- end-user-doc -->
         * @model kind="operation"
         * @generated
         */
        int getFeatureID();
        /**
         * <!-- begin-user-doc -->
         * Returns the {@link EClassifier#getInstanceClass instance class} of the {@link #getEContainingClass containing} class.
         * @return the instance class of the containing class.
         * <!-- end-user-doc -->
         * @model kind="operation"
         * @generated
         */
        object getContainerClass();

        /**
         * Returns whether the type is a feature map.
         * @return whether the type is a feature map.
         */
        bool isFeatureMap();

        /**
         * Returns whether this is an {@link EAttribute attribute} that is an {@link EAttribute#isID() ID}.
         * @return whether this is an attribute that is an ID.
         */
        public bool isID();
        /**
         * Returns whether this is a {@link EReference reference} that {@link EReference#isResolveProxies() resolves proxies}.
         * @return whether this is a reference that resolves proxies.
         */
        public bool isResolveProxies();
        /**
         * Returns whether this is a {@link EReference reference} that is a {@link EReference#isContainer() container}.
         * @return whether this is a reference that is a container. 
         */
        public bool isContainer();
        /**
         * Returns whether this is a {@link EReference reference} that is a {@link EReference#isContainment() containment}.
         * @return whether this is a reference that is a containment.
         */
        public bool isContainment();
        /**
         * Returns the {@link EReference#getEOpposite() opposite} if this is {@link EReference reference} that has one.
         * @return the opposite if this is reference that has one.
         */
        public EReference getEOpposite();
    }
}
