using System.Reflection;
using Refactoring.DecoratorPattern;
using Refactoring.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        var composite = new CompositeComponent();
        composite.AddComponent(new Leaf());
        composite.AddComponent(new Leaf());
        composite.AddComponent(new Leaf());
        component = composite;
        component.Something();

    }
    static IComponent component;
}