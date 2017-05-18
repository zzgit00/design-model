using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 单例模式：
 *      
 **/
namespace SingletonModel
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonA s1 = SingletonA.GetInstance();
            SingletonA s2 = SingletonA.GetInstance();

            if (s1 == s2)
                Console.WriteLine("===");

            Console.WriteLine("\n按下任意键继续...");
            Console.ReadKey();
        }
    }

    class SingletonA
    {
        private static SingletonA instance;
        private static readonly object syncRoot = new object();

        private SingletonA()
        {

        }

        public static SingletonA GetInstance()
        {
            if (instance == null)
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new SingletonA();
                }

            return instance;
        }
    }

    sealed class SigletonB
    {
        private static readonly SigletonB instance = new SigletonB();

        private SigletonB() { }

        public static SigletonB GetInstance()
        {
            return instance;
        }
    }
}
