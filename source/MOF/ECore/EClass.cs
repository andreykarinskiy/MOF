using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EClass : EClassifier
    {
        bool IsAbstract { get; set; }

        bool IsInterface { get; set; }

        IList<EClass> ESuperTypes { get; }

        IList<EClass> EAllSuperTypes { get; }

        EAttribute EIDAttribute { get; }

        IList<EStructuralFeature> EStructuralFeatures { get; }

        IList<EGenericType> EGenericSuperTypes { get; }

        IList<EGenericType> EAllGenericSuperTypes { get; }

        IList<EAttribute> EAttributes { get; }

        IList<EAttribute> EAllAttributes { get; }

        IList<EReference> EReferences { get; }

        IList<EReference> EAllReferences { get; }

        IList<EReference> EAllContainments { get; }

        IList<EStructuralFeature> EAllStructuralFeatures { get; }

        IList<EOperation> EOperations { get; }

        IList<EOperation> EAllOperations { get; }

        bool IsSuperTypeOf(EClass someClass);

        int FeatureCount { get; }

        EStructuralFeature GetEStructuralFeature(int featureID);

        EStructuralFeature GetEStructuralFeature(string featureName);

        int OperationCount { get; }

        EOperation GetEOperation(int operationID);

        int GetOperationID(EOperation operation);

        EOperation GetOverride(EOperation operation);

        EGenericType GetFeatureType(EStructuralFeature feature);

        int GetFeatureID(EStructuralFeature feature);
    }
}
