using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 解释器模式：
 *      给定一个语言，定义它的文法的一种表示，并定义一个解释器，
 *      这个解释器使用该表示来解释语言中的句子。
 **/
namespace InterpreterModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            IList<AbstractExpression> list = new List<AbstractExpression>();

            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
                exp.Interpret(context);

            Console.WriteLine("\n按任意键继续...");
            Console.ReadKey();
        }
    }

    interface AbstractExpression
    {
        void Interpret(Context context);
    }

    class TerminalExpression : AbstractExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }

    class NonterminalExpression : AbstractExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }

    class Context
    {
        private String input;
        private String output;

        public string Input { get => input; set => input = value; }
        public string Output { get => output; set => output = value; }
    }
}
