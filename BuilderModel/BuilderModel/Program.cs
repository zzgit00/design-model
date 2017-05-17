using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 建造者模式：
 *      将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。
 **/
namespace BuilderModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            Console.WriteLine("\n输入任意键继续...");
            Console.ReadKey();
        }
    }

    class Product
    {
        IList<String> parts = new List<String>();

        public void Add(String part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n产品 创建 -------");
            foreach (String part in parts)
                Console.WriteLine(part);
        }
    }

    interface Builder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }

    class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();

        public void BuildPartA()
        {
            product.Add("部件A");
        }

        public void BuildPartB()
        {
            product.Add("部件B");
        }

        public Product GetResult()
        {
            return product;
        }
    }

    class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();

        public void BuildPartA()
        {
            product.Add("部件X");
        }

        public void BuildPartB()
        {
            product.Add("部件Y");
        }

        public Product GetResult()
        {
            return product;
        }
    }

    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
