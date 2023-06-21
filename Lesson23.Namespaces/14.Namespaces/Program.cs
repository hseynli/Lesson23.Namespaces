// Eyni səviyyədə olan iki fərqli namespace-lər daxilində olan üzvlərə birbaşa olaraq import etmədən müraciəti təmin etmir.

namespace MyNamespace
{
    namespace NamespaceA
    {
        class MyClassA
        {
            //MyClassB my = new MyClassB();
        }
    }

    namespace NamespaceB
    {
        class MyClassB
        {
            //MyClassA my = new MyClassA();
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
            MyClassA myA = new MyClassA();
            MyClassB myB = new MyClassB();
        }
    }
}
