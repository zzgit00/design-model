using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 代理模式：
 *      为其他对象提供一种代理以控制对这个对象的访问。
 */
namespace ProxyModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();

            Console.ReadKey();
        }
    }

    abstract class Subject
    {
        public abstract void Request();
    }

    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实的请求");
        }
    }

    class Proxy : Subject
    {
        private RealSubject subject;

        public override void Request()
        {
            if (subject == null)
                subject = new RealSubject();

            subject.Request();
        }
    }
}
