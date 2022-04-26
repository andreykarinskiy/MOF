using MOF.Impl;

namespace MOF.ECore
{
    public static class EFactoryExtension
    {
        public static EAnnotation CreateEAnnotation(this EFactory factory, string source, EModelElement target)
        {
            var annotation = factory.CreateEAnnotation();

            // Текст аннотации.
            annotation.Source = source;

            // Двусторонняя связь с элементом, который описывается данной аннотацией.
            annotation.EModelElement = target;
            target.EAnnotations.Add(annotation);

            return annotation;
        }

        public static EPackage CreateEPackage(this EFactory factory, string packageName, EPackage super)
        {
            var package = (EPackageImpl) factory.CreateEPackage();

            // Имя пакета (должно быть уникальным).
            package.Name = packageName;

            // Двусторонняя связь с родительским пакетом.
            package.ESuperPackage = super;
            super.ESubpackages.Add(package);

            return package;
        }
    }
}
