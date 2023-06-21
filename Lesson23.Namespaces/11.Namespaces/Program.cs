// Texniki olaraq eyni adlı bir neçə namespace yaratmaq mümkündür.
// Məntiqi olaraq eyni adlı bir neçə namespace bir namespace-ə birləşdirilir.

namespace MyNamespace
{
    class MyClass { }
}

namespace MyNamespace
{
    // Eyni adlı namespace-lərdə eyniadlı klaslar yaratmaq mümkün deyil.

    //class MyClass { }  // Xəta.
}

namespace Namespaces
{
    class Program
    {
        static void Main()
        {
            MyNamespace.MyClass my = new MyNamespace.MyClass();
        }
    }
}
