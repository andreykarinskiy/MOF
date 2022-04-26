using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EPackage : ENamedElement
    {
        string NsURI { get; set; }

        string NsPrefix { get; set; }

        EFactory EFactoryInstance { get; }

        IList<EClassifier> EClassifiers { get; }

        IList<EPackage> ESubpackages { get; }

        EPackage ESuperPackage { get; internal set; }

        EClassifier GetEClassifier(string name);
    }
}
