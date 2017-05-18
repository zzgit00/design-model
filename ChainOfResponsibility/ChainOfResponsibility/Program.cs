using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 职责链模式：
 *      使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合关系。
 *      将这个对象连成一条链，并沿着这条链传递该请求，知道有一个对象处理它为止。
 **/
namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handle h1 = new ConcreteHandle1();
            Handle h2 = new ConcreteHandle2();
            Handle h3 = new ConcreteHandle3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };
            foreach (int request in requests)
                h1.HandleRequest(request);

            Console.WriteLine("\n按任意键继续...");
            Console.ReadKey();
        }
    }

    abstract class Handle
    {
        protected Handle successor;

        public void SetSuccessor(Handle successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    class ConcreteHandle1 : Handle
    {
        public override void HandleRequest(int request)
        {
            if (request > 0 && request < 10)
                Console.WriteLine("{0} 处理请求 {1}", this.GetType().Name, request);
            else if (successor != null)
                successor.HandleRequest(request);
        }
    }

    class ConcreteHandle2 : Handle
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
                Console.WriteLine("{0} 处理请求 {1}", this.GetType().Name, request);
            else if (successor != null)
                successor.HandleRequest(request);
        }
    }

    class ConcreteHandle3 : Handle
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
                Console.WriteLine("{0} 处理请求 {1}", this.GetType().Name, request);
            else if (successor != null)
                successor.HandleRequest(request);
        }
    }
}
