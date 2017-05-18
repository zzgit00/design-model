using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 享原模式：
 *      运用共享技术有效地支持最大量粒度的对象。
 **/
namespace FlyweightModel
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 22;

            FlyweightFactory f = new FlyweightFactory();

            Flyweight fx = f.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = f.GetFlyweight("Y");
            fx.Operation(--extrinsicstate);

            Flyweight fz = f.GetFlyweight("Z");
            fx.Operation(--extrinsicstate);

            Flyweight uf = new UnsharedConcreteFlyweight();
            uf.Operation(--extrinsicstate);

            Console.WriteLine("\n输入任意键继续...");
            Console.ReadKey();
        }
    }

    interface Flyweight
    {
        void Operation(int extrinsicstate);
    }

    class ConcreteFlyweight : Flyweight
    {
        public void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体Flyweight:" + extrinsicstate);
        }
    }

    class UnsharedConcreteFlyweight : Flyweight
    {
        public void Operation(int extrinsicstate)
        {
            Console.WriteLine("不共享的具体Flyweight:" + extrinsicstate);
        }
    }

    class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(String key)
        {
            return (Flyweight)flyweights[key];
        }
    }

}
