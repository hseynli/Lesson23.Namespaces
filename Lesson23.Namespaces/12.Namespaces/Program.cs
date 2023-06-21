namespace MyNamespace
{
    class MyClass { }

    namespace MyNamespace
    {
        // Daxili namespace-lərdə eyni adlı üzvlərdən istifadə etmək mümkündür.

        class MyClass { }
    }
}


namespace Namespaces
{
    class Program
    {
        static void Main()
        {
            MyNamespace.MyClass my1 = new MyNamespace.MyClass();
            MyNamespace.MyNamespace.MyClass my2 = new MyNamespace.MyNamespace.MyClass();
        }
    }
}
