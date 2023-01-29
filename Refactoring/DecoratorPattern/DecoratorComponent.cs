using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refactoring.Interfaces;

namespace Refactoring.DecoratorPattern
{
    public class DecoratorComponent : IComponent
    {
        private readonly IComponent decoratedComponent;
        public DecoratorComponent(IComponent decoratedComponent)
        {
            this.decoratedComponent = decoratedComponent;
        }
        public void Something()
        {
            SomethingElse();
            decoratedComponent.Something();
        }
        private void SomethingElse()
        {
        }
    }
}
