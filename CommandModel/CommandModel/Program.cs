﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 命令模式：
 *      将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化；
 *      对请求排队或记录请求日志，以及支持可撤销的操作。
 **/
namespace CommandModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);
            Invoker i = new Invoker();

            i.SetCommand(c);
            i.ExecuteComand();

            Console.WriteLine("\n按任意键继续...");
            Console.ReadKey();
        }
    }

    abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        abstract public void Execute();
    }

    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }

    class Invoker
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExecuteComand()
        {
            command.Execute();
        }
    }

    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("执行请求");
        }
    }
}
