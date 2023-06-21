namespace NamespaceA
{
    namespace NamespaceB
    {
        namespace NamespaceC
        {
            class MyClassC { }
        }
        class MyClassB { }
    }
    class MyClassA { }
}

// Daxili namespace-in təkrar yaradılması.

namespace NamespaceA.NamespaceB.NamespaceC
{
    class MyClassC2 { }
}

namespace Namespaces
{
    using NamespaceA.NamespaceB.NamespaceC;

    class Program
    {
        static void Main()
        {
            MyClassC myC = new MyClassC();
            MyClassC2 myC2 = new MyClassC2();
        }
    }
}
