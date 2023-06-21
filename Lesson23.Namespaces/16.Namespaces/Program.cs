// Daxili və xarici namespace-lərdə eyniadlı klaslar olanda, xaricdə olan klasın gizlənilməsi baş verir.
// Xaricdə olan klasa daxildən müraciət etmək üçün həmin klasın adını namespace ilə yazmaq lazımdır.

namespace NamespaceA
{
    namespace NamespaceB
    {
        class MyClass { }  // Eyniadlı klas.

        class MyClassB
        {
            MyClass my1;
            NamespaceA.MyClass my2; // Birbaşa müraciət mümkün deyil.
            MyClassA my3;           // Birbaşa müraciət mümkündür.
        }
    }

    class MyClass { }      // Eyniadlı klas.
    class MyClassA { }
}


namespace Namespaces
{
    using NamespaceA;
    using NamespaceA.NamespaceB;

    class Program
    {
        static void Main()
        {
        }
    }
}
