using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EDataType : EClassifier
    {
        bool IsSerializable { get; set; }
    }
}
