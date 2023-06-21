// İmport mövcüd olmadıqda daxili namespace-lərdən üzvlərin görünməsi.

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
                MyClassC myC = new MyClassC();
            }
        }

        class MyClassB
        {
            MyClassA myA = new MyClassA();
            MyClassB myB = new MyClassB();
            //MyClassC myC = new MyClassC();
        }
    }

    class MyClassA
    {
        MyClassA myA = new MyClassA();
        //MyClassB myB = new MyClassB(); 
        //MyClassC myC = new MyClassC();
    }
}

namespace Namespaces
{
    class Program
    {
        static void Main()
        {
        }
    }
}
