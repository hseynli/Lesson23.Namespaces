namespace Abstraction;

internal abstract class AbstractPerson
{
}

class Person : AbstractPerson
{
    public Person()
    {
        Console.WriteLine("Person created...");
    }
}