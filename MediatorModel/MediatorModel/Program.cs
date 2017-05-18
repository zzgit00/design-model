using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 中介者模式：
 *      用一个中介对象来封装一系列的对象交互。中介者使各对象不需要显示的引用，
 *      从而使其耦合松散，而且可以独立改变它们之间的交互。
 **/
namespace MediatorModel
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("aaa");
            c2.Send("bbb");

            Console.WriteLine("\n按任意键继续...");
            Console.ReadKey();
        }
    }

    interface Mediator
    {
        void Send(String message, Colleague colleague);
    }

    class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 colleague1;
        private ConcreteColleague2 colleague2;

        internal ConcreteColleague1 Colleague1 { set => colleague1 = value; }
        internal ConcreteColleague2 Colleague2 { set => colleague2 = value; }

        public void Send(string message, Colleague colleague)
        {
            if (colleague == colleague1)
                colleague2.Notify(message);
            else
                colleague1.Notify(message);
        }
    }

    class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        public void Notify(String message)
        {
            Console.WriteLine("同事 1 得到消息："+message);
        }

        public void Send(String message)
        {
            mediator.Send(message, this);
        }
    }

    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public void Notify(String message)
        {
            Console.WriteLine("同事 2 得到消息：" + message);
        }

        public void Send(String message)
        {
            mediator.Send(message, this);
        }
    }
}
