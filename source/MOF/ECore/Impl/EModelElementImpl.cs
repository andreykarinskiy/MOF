using MOF.Common.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore.Impl
{
    internal class EModelElementImpl : MinimalEObjectImpl, EModelElement
    {
        public EAnnotation getEAnnotation(string source)
        {
            throw new NotImplementedException();
        }

        public EList<EAnnotation> getEAnnotations()
        {
            throw new NotImplementedException();
        }
    }
}
