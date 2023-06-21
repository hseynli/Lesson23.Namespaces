namespace NamespaceA
{
    namespace NamespaceB
    {
        namespace NamespaceC
        {
            class MyClassC
            {
                MyClassA myA = new MyClassA();
                MyClassB myB = new MyClassB();
                MyClassB2 myB2 = new MyClassB2();
            }
        }
        class MyClassB { }
    }
    class MyClassA { }
}

// Daxili namespace-in təkrar yaradılması.

namespace NamespaceA.NamespaceB
{
    class MyClassB2 { }
}

namespace Namespaces
{
    using NamespaceA.NamespaceB;

    class Program
    {
        static void Main()
        {
            MyClassB myB = new MyClassB();
            MyClassB2 myB2 = new MyClassB2();
        }
    }
}
