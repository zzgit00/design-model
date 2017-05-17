using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 外观模式：
 *      为子系统中的一组接口提供一个一致的界面，此模式定义了一个高层接口，
 *      这个接口使得这一子系统更加容易使用。
 **/
namespace FacadeModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            Console.WriteLine("\n按下任意键继续...");
            Console.ReadKey();
        }
    }

    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("子系统方法一");
        }
    }

    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("子系统方法二");
        }
    }

    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("子系统方法三");
        }
    }

    class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("子系统方法四");
        }
    }

    class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n 方法组 A =============");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\n 方法组 B =============");
            one.MethodOne();
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
