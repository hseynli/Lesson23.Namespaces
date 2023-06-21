// Eyni səviyyədə olan iki fərqli namespace-lər daxilində olan üzvlərə birbaşa olaraq import etmədən müraciəti təmin etmir.
namespace MyNamespace
{
    namespace NamespaceA
    {
        class BaseClass
        {
        }
    }

    namespace NamespaceB
    {
        class DerivedClass : NamespaceA.BaseClass
        {
        }
    }
}

namespace Namespaces
{
    using MyNamespace.NamespaceA;
    using MyNamespace.NamespaceB;

    class Program
    {
        static void Main()
        {
            BaseClass instance1 = new BaseClass();
            DerivedClass instance2 = new DerivedClass();
        }
    }
}