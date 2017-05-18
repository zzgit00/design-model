using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 桥接模式：
 *      将抽象部分与它的实现部分分离，使他们都可以独立变化。
 **/
namespace BridgeModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new Abstraction();

            ab.SetImplementor(new ConcreteImplementorA());
            ab.Operation();

            ab.SetImplementor(new ConcreteImplementorB());
            ab.Operation();

            Console.WriteLine("\n按下任意键继续...");
            Console.ReadKey();
        }
    }

    interface Implementor
    {
        void Operation();
    }

    class ConcreteImplementorA : Implementor
    {
        public void Operation()
        {
            Console.WriteLine("具体实现 A 的方法执行");
        }
    }

    class ConcreteImplementorB : Implementor
    {
        public void Operation()
        {
            Console.WriteLine("具体实现 B 的方法执行");
        }
    }

    class Abstraction
    {
        protected Implementor implementor;

        public void SetImplementor(Implementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    class RefinedAbstraction:Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
