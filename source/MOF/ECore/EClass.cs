using MOF.Common.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    /// <summary>
    /// A representation of the model object '<em><b>EClass</b></em>'.
    /// </summary>
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EClass.java
    public interface EClass : EClassifier
    {
        /// <summary>
        /// Returns the value of the Abstract attribute.
        /// For an abstract class,
        /// the generated implementation class will be abstract,
        /// and the generated factory will not provide support for creating an instance.
        /// </summary>
        /// <returns></returns>
        bool IsAbstract();

        void SetAbstract(bool value);

        /// <summary>
        /// Returns the value of the Interface attribute.
        /// For an interface class,
        /// there will be no generated implementation class.
        /// </summary>
        /// <returns></returns>
        bool IsInterface();
        
        void SetInterface(bool value);

        /// <summary>
        /// Returns the value of the ESuper Types reference list.
        /// </summary>
        /// <returns></returns>
        EList<EClass> GetESuperTypes();

        /// <summary>
        /// Returns the value of the EAll Super Types reference list.
        /// </summary>
        /// <returns></returns>
        EList<EClass> GetEAllSuperTypes();

        /// <summary>
        /// Returns the value of the EID Attribute reference.
        /// </summary>
        /// <returns></returns>
        EAttribute GetEIDAttribute();

        /// <summary>
        /// Returns the value of the >EStructural Features containment reference list.
        /// </summary>
        /// <returns></returns>
        EList<EStructuralFeature> GetEStructuralFeatures();

        /// <summary>
        /// Returns the value of the EGeneric Super Types containment reference list.
        /// </summary>
        /// <returns></returns>
        EList<EGenericType> GetEGenericSuperTypes();

        /// <summary>
        /// Returns the value of the EAll Generic Super Types reference list.
        /// </summary>
        /// <returns></returns>
        EList<EGenericType> GetEAllGenericSuperTypes();

        /// <summary>
        /// Returns the value of the EAttributes reference list.
        /// </summary>
        /// <returns></returns>
        EList<EAttribute> GetEAttributes();

        /// <summary>
        /// Returns the value of the EAll Attributes reference list.
        /// </summary>
        /// <returns></returns>
        EList<EAttribute> GetEAllAttributes();

        /// <summary>
        /// Returns the value of the EReferences reference list.
        /// </summary>
        /// <returns></returns>
        EList<EReference> GetEReferences();

        /// <summary>
        /// Returns the value of the EAll References reference list.
        /// </summary>
        /// <returns></returns>
        EList<EReference> GetEAllReferences();

        /// <summary>
        /// Returns the value of the EAll Containments reference list.
        /// </summary>
        /// <returns></returns>
        EList<EReference> GetEAllContainments();

        /// <summary>
        /// Returns the value of the EAll Structural Features reference list.
        /// </summary>
        /// <returns></returns>
        EList<EStructuralFeature> GetEAllStructuralFeatures();

        /// <summary>
        /// Returns the value of the EOperations containment reference list.
        /// </summary>
        /// <returns></returns>
        EList<EOperation> GetEOperations();

        /// <summary>
        /// Returns the value of the EAll Operations reference list.
        /// </summary>
        /// <returns></returns>
        EList<EOperation> GetEAllOperations();

        /// <summary>
        /// Returns whether this class is the same as, or a super type of, some other class.
        /// </summary>
        bool IsSuperTypeOf(EClass someClass);

        /// <summary>
        /// Returns the number of features.
        /// </summary>
        /// <returns></returns>
        int GetFeatureCount();

        /// <summary>
        /// Returns the feature with this ID.
        /// </summary>
        EStructuralFeature GetEStructuralFeature(int featureID);

        /// <summary>
        /// Returns the feature with this name.
        /// </summary>
        EStructuralFeature GetEStructuralFeature(string featureName);

        /// <summary>
        /// Returns the number of operations.
        /// </summary>
        int GetOperationCount();

        /// <summary>
        /// Returns the operation with this ID.
        /// </summary>
        EOperation GetEOperation(int operationID);

        /// <summary>
        /// Returns the ID of the operation relative to this class, or -1 if the operation is not in this class.
        /// </summary>
        int GetOperationID(EOperation operation);

        /// <summary>
        /// Returns the operation that overrides this operation.
        /// </summary>
        EOperation GetOverride(EOperation operation);

        /// <summary>
        /// Returns the generic type representing the effective {@link EcoreUtil#getReifiedType(EClass, EGenericType) reified type} of the feature in the context of this specific class.
        /// </summary>
        EGenericType GetFeatureType(EStructuralFeature feature);

        /// <summary>
        /// Returns the ID of the feature relative to this class, or -1 if the feature is not in this class.
        /// </summary>
        int GetFeatureID(EStructuralFeature feature);
    }
}
