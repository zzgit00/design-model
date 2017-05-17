﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 模板方法模式：
 *      定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。模板方法使得子类
 *      可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
 **/
namespace TemplateMethodModel
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass c;

            c = new ConcreteClassA();
            c.TemplateMethod();

            c = new ConcreteClassB();
            c.TemplateMethod();

            Console.WriteLine("按下任意键继续...");
            Console.ReadKey();
        }
    }

    abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("抽象模板");
        }
    }

    class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体类 A 方法 1 实现");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类 A 方法 2 实现");
        }
    }

    class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体类 B 方法 1 实现");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类 B 方法 2 实现");
        }
    }
}
