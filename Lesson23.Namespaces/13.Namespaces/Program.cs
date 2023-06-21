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
    using MyNamespace;
    using MyNamespace.MyNamespace;

    class Program
    {
        static void Main()
        {
            // Əgər import olunan namespace-lərdə eyniadlı üzvlər varsa, onda onların instance-nı yaradan zaman tam (namespace ilə) adını yazmaq lazımdır.

            //MyClass my = new MyClass();  // Xəta.

            MyNamespace.MyClass my1 = new MyNamespace.MyClass();
            MyNamespace.MyNamespace.MyClass my2 = new MyNamespace.MyNamespace.MyClass();
        }
    }
}
