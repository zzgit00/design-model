using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 访问者模式：
 *      表示一个作用于某对象结构中的各元素的操作。
 *      它使你可以在不改变各元素的类的前提下定义作用于这些元素的新操作。
 **/
namespace VisitorModel
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            o.Accept(v1);
            o.Accept(v2);

            Console.WriteLine("\n按任意键继续...");
            Console.ReadKey();
        }
    }

    interface Visitor
    {
        void VisitConcreteElementA(ConcreteElementA elementA);
        void VisitConcreteElementB(ConcreteElementB elementB);
    }

    class ConcreteVisitor1 : Visitor
    {
        public void VisitConcreteElementA(ConcreteElementA elementA)
        {
            Console.WriteLine("{0} 被 {1} 访问",elementA.GetType().Name,this.GetType().Name);
        }

        public void VisitConcreteElementB(ConcreteElementB elementB)
        {
            Console.WriteLine("{0} 被 {1} 访问", elementB.GetType().Name, this.GetType().Name);
        }
    }

    class ConcreteVisitor2 : Visitor
    {
        public void VisitConcreteElementA(ConcreteElementA elementA)
        {
            Console.WriteLine("{0} 被 {1} 访问", elementA.GetType().Name, this.GetType().Name);
        }

        public void VisitConcreteElementB(ConcreteElementB elementB)
        {
            Console.WriteLine("{0} 被 {1} 访问", elementB.GetType().Name, this.GetType().Name);
        }
    }

    interface Element
    {
        void Accept(Visitor visitor);
    }

    class ConcreteElementA : Element
    {
        public void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
    }

    class ConcreteElementB : Element
    {
        public void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }
    }

    class ObjectStructure
    {
        private IList<Element> elements = new List<Element>();

        public void Attach(Element element)
        {
            elements.Add(element);
        }

        public void Detach(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element e in elements)
                e.Accept(visitor);
        }
    }
}
