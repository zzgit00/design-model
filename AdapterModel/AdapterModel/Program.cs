using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 适配器模式：
 *      将一个类的接口转换成客户希望的另一个接口。
 *      Adapter 模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作。
 **/
namespace AdapterModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Target t = new Adapter();
            t.Request();

            Console.WriteLine("\n按任意键继续...");
            Console.ReadKey();
        }
    }

    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求");
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求");
        }
    }

    class Adapter:Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            base.Request();
            adaptee.SpecificRequest();
        }
    }
}