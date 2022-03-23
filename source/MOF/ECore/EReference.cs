using MOF.Common.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EReference.java
    public interface EReference : EStructuralFeature
    {
        /**
   * Returns the value of the '<em><b>Containment</b></em>' attribute.
   * <!-- begin-user-doc -->
   * A reference is a containment if it represents by-value content.
   * <!-- end-user-doc -->
   * @return the value of the '<em>Containment</em>' attribute.
   * @see #setContainment(boolean)
   * @see org.eclipse.emf.ecore.EcorePackage#getEReference_Containment()
   * @model
   * @generated
   */
        bool isContainment();
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EReference#isContainment <em>Containment</em>}' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>Containment</em>' attribute.
         * @see #isContainment()
         * @generated
         */
        void setContainment(bool value);
        /**
         * Returns the value of the '<em><b>Container</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <p>
         * A reference is a container if it has an {@link #getEOpposite opposite} that is a {@link #isContainment containment}.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>Container</em>' attribute.
         * @see org.eclipse.emf.ecore.EcorePackage#getEReference_Container()
         * @model transient="true" changeable="false" volatile="true" derived="true"
         * @generated
         */
        bool isContainer();
        /**
         * Returns the value of the '<em><b>Resolve Proxies</b></em>' attribute.
         * The default value is <code>"true"</code>.
         * <!-- begin-user-doc -->
         * <p>
         * It represents whether {@link EObject#eIsProxy proxies} will be automatically resolved.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>Resolve Proxies</em>' attribute.
         * @see #setResolveProxies(boolean)
         * @see org.eclipse.emf.ecore.EcorePackage#getEReference_ResolveProxies()
         * @model default="true"
         * @generated
         */
        bool isResolveProxies();
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EReference#isResolveProxies <em>Resolve Proxies</em>}' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>Resolve Proxies</em>' attribute.
         * @see #isResolveProxies()
         * @generated
         */
        void setResolveProxies(bool value);
        /**
         * Returns the value of the '<em><b>EOpposite</b></em>' reference.
         * <!-- begin-user-doc -->
         * <p>
         * It represent the other end of a bidirectional relation.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>EOpposite</em>' reference.
         * @see #setEOpposite(EReference)
         * @see org.eclipse.emf.ecore.EcorePackage#getEReference_EOpposite()
         * @model
         * @generated
         */
        EReference getEOpposite();
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EReference#getEOpposite <em>EOpposite</em>}' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>EOpposite</em>' reference.
         * @see #getEOpposite()
         * @generated
         */
        void setEOpposite(EReference value);
        /**
         * Returns the value of the '<em><b>EReference Type</b></em>' reference.
         * <!-- begin-user-doc -->
         * <p>
         * The {@link #getEType() type} of a reference must always be a class; this method provides access to it.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>EReference Type</em>' reference.
         * @see org.eclipse.emf.ecore.EcorePackage#getEReference_EReferenceType()
         * @model required="true" transient="true" changeable="false" volatile="true" derived="true"
         * @generated
         */
        EClass getEReferenceType();
        /**
         * Returns the value of the '<em><b>EKeys</b></em>' reference list.
         * The list contents are of type {@link org.eclipse.emf.ecore.EAttribute}.
         * <!-- begin-user-doc -->
         * <p>
         * This represents a subset of the attributes on the referenced type that uniquely identify an instance within this reference.
         * </p>
         * <!-- end-user-doc -->
         * @return the value of the '<em>EKeys</em>' reference list.
         * @see org.eclipse.emf.ecore.EcorePackage#getEReference_EKeys()
         * @model
         * @generated
         */
        EList<EAttribute> getEKeys();
    }
}
