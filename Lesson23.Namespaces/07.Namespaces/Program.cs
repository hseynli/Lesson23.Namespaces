using NamespaceA;
using NamespaceA.NamespaceB;
using NamespaceA.NamespaceB.NamespaceC;

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

// Bu yerdə import mümkün deyil.
// İmport yalnız namespace-in bədənində və ya digər bütün namespace-lərdən əvvəl yazılmalıdır.

//using NamespaceA;
//using NamespaceA.NamespaceB;
//using NamespaceA.NamespaceB.NamespaceC;

namespace Namespaces
{
    class Program
    {
        static void Main()
        {
            MyClassA myA = new MyClassA();
            MyClassB myB = new MyClassB();
            MyClassC myC = new MyClassC();
        }
    }
}
