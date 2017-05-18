using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 迭代器模式：
 *      提供一种方法顺序访问一个聚合对象中各个元素，而又不暴露该对象的内部表示。
 **/
namespace IteratorModel
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();

            a[0] = "aaa";
            a[1] = "bbb";
            a[2] = "ccc";
            a[3] = "ddd";
            a[4] = "eee";
            a[5] = "fff";

            Iterator i = a.CreateIterator();
            while(!i.IsDone())
            {
                Console.WriteLine("{0}",i.CurrentItem());
                i.Next();
            }

            Console.WriteLine("\n按任意键继续...");
            Console.ReadKey();
        }
    }

    interface Iterator
    {
        Object First();
        Object Next();
        bool IsDone();
        Object CurrentItem();
    }

    interface Aggregate
    {
        Iterator CreateIterator();
    }

    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public object CurrentItem()
        {
            return aggregate[current];
        }

        public object First()
        {
            return aggregate[0];
        }

        public bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public object Next()
        {
            object ret = null;
            current++;
            if (current < aggregate.Count)
                ret = aggregate[current];
            return ret;
        }
    }

    class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<Object>();

        public int Count { get => items.Count; }

        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
