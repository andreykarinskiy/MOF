using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public sealed class EClassImpl : EClassifierImpl, EClass
    {
        private readonly Lazy<List<EClass>> superTypes = new(() => new List<EClass>());

        public bool IsAbstract { get; set; }
        public bool IsInterface { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IList<EClass> ESuperTypes => superTypes.Value;

        public IList<EClass> EAllSuperTypes => throw new NotImplementedException();

        public EAttribute EIDAttribute => throw new NotImplementedException();

        public IList<EStructuralFeature> EStructuralFeatures => throw new NotImplementedException();

        public IList<EGenericType> EGenericSuperTypes => throw new NotImplementedException();

        public IList<EGenericType> EAllGenericSuperTypes => throw new NotImplementedException();

        public IList<EAttribute> EAttributes => throw new NotImplementedException();

        public IList<EAttribute> EAllAttributes => throw new NotImplementedException();

        public IList<EReference> EReferences => throw new NotImplementedException();

        public IList<EReference> EAllReferences => throw new NotImplementedException();

        public IList<EReference> EAllContainments => throw new NotImplementedException();

        public IList<EStructuralFeature> EAllStructuralFeatures => throw new NotImplementedException();

        public IList<EOperation> EOperations => throw new NotImplementedException();

        public IList<EOperation> EAllOperations => throw new NotImplementedException();

        public int FeatureCount => throw new NotImplementedException();

        public int OperationCount => throw new NotImplementedException();

        public override void Accept(IEcoreVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public EOperation GetEOperation(int operationID)
        {
            throw new NotImplementedException();
        }

        public EStructuralFeature GetEStructuralFeature(int featureID)
        {
            throw new NotImplementedException();
        }

        public EStructuralFeature GetEStructuralFeature(string featureName)
        {
            throw new NotImplementedException();
        }

        public int GetFeatureID(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public EGenericType GetFeatureType(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public int GetOperationID(EOperation operation)
        {
            throw new NotImplementedException();
        }

        public EOperation GetOverride(EOperation operation)
        {
            throw new NotImplementedException();
        }

        public bool IsSuperTypeOf(EClass someClass)
        {
            throw new NotImplementedException();
        }
    }
}
