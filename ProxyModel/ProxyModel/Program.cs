using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
