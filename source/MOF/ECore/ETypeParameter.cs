using MOF.Common.Util;

namespace MOF.ECore
{
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/ETypeParameter.java
    public interface ETypeParameter : ENamedElement
    {
        /**
   * Returns the value of the '<em><b>EBounds</b></em>' containment reference list.
   * The list contents are of type {@link org.eclipse.emf.ecore.EGenericType}.
   * <!-- begin-user-doc -->
   * <p>
   * It represents the bounds on the type of argument that be may be used to instantiate this parameter.
   * </p>
   * <!-- end-user-doc -->
   * @return the value of the '<em>EBounds</em>' containment reference list.
   * @see org.eclipse.emf.ecore.EcorePackage#getETypeParameter_EBounds()
   * @model containment="true"
   * @generated
   */
        EList<EGenericType> getEBounds();
    }
}
