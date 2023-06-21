// Namespaces. Tiplərin psevdonimləri.
namespace NamespaceA
{
    namespace NamespaceB
    {
        namespace NamespaceC
        {
            class MyClassC
            {
                public void Method()
                {
                    System.Console.WriteLine("Hello world!");
                }
            }
        }
        class MyClassB { }
    }
    class MyClassA { }
}

namespace Namespaces
{
    // NamespaceA.NamespaceB.NamespaceC namespace-də yerləşən MyClassC adlı klas üçün MyClass adlı psevdoniminin yaradılması.

    using MyClass = NamespaceA.NamespaceB.NamespaceC.MyClassC;

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();
            my.Method();
            System.Console.WriteLine(my.GetType());
        }
    }
}
