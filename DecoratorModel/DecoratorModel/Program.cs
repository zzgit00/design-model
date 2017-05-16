using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Component c = new ConcreteComponent();
            ConcreteDecoratorA a = new ConcreteDecoratorA();
            ConcreteDecoratorB b = new ConcreteDecoratorB();

            a.SetComponent(c);
            b.SetComponent(a);

            b.Operation();
            Console.ReadKey();
        }
    }

    interface Component
    {
        void Operation();
    }

    class ConcreteComponent : Component
    {
        public void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }

    class Decorator : Component
    {
        private Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public virtual void Operation()
        {
            if (component != null)
                component.Operation();
        }
    }

    class ConcreteDecoratorA : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("装饰A类");
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("装饰B类");
        }
    }
}
