using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public abstract class EClassifierImpl : ENamedElementImpl, EClassifier
    {
        public string InstanceClassName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Type InstanceClass { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object DefaultValue => throw new NotImplementedException();

        public EPackage EPackage => throw new NotImplementedException();

        public IList<ETypeParameter> ETypeParameters => throw new NotImplementedException();

        public int ClassifierID => throw new NotImplementedException();

        public string getInstanceTypeName()
        {
            throw new NotImplementedException();
        }

        public bool IsInstance(object instance)
        {
            throw new NotImplementedException();
        }

        public void setInstanceTypeName(string value)
        {
            throw new NotImplementedException();
        }
    }
}
