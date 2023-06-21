namespace NamespaceA
{
    class MyClassA
    {
        MyClassA my;

        public MyClassA()  // StackOverflowException
        {
            System.Console.WriteLine("Constructor MyClassA");

            // Reflektiv assosasiya, ilkin instance yaradılan sonra dövrü şəkildə yenidən instance-ın yaradılmasına gətirib çıxarır.
            my = new MyClassA();
        }
    }
}

namespace Namespaces
{
    using NamespaceA;

    class Program
    {
        static void Main()
        {
            // MyClassA klasının instance-nı yaratmağa cəhd etmək.
            MyClassA myA = new MyClassA();
        }
    }
}
