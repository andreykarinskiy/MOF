using MOF.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public static class EPackageExtension
    {
        public static EPackage AddPackage(this EPackage superPackage, EPackage subPackage)
        {
            superPackage.ESubpackages.Add(subPackage);
            subPackage.ESuperPackage = superPackage;

            return superPackage;
        }
    }
}
