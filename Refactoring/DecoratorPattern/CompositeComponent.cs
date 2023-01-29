using System;
using Refactoring.Interfaces;

namespace Refactoring.DecoratorPattern
{
    public class CompositeComponent : IComponent
    {
        public CompositeComponent()
        {
            children = new List<IComponent>();
        }
        public void AddComponent(IComponent component)
        {
            children.Add(component);
        }
        public void RemoveComponent(IComponent component)
        {
            children.Remove(component);
        }
        public void Something()
        {
            foreach (var child in children)
            {
                child.Something();
            }
        }
        private ICollection<IComponent> children;
    }
}
