using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 状态模式：
 *      当一个对象的内在状态改变时允许改变其行为，这个对象看起来像是改变了其类。
 **/
namespace StateModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Work w = new Work();
            w.Hour = 9;
            w.WriteProgram();
            w.Hour = 10;
            w.WriteProgram();
            w.Hour = 12;
            w.WriteProgram();
            w.Hour = 13;
            w.WriteProgram();
            w.Hour = 14;
            w.WriteProgram();
            w.Hour = 17;

            w.Finish = false;

            w.WriteProgram();
            w.Hour = 19;
            w.WriteProgram();
            w.Hour = 22;
            w.WriteProgram();

            Console.WriteLine("\n按下任意键继续...");
            Console.ReadKey();
        }
    }

    public interface State
    {
        void WriteProgram(Work w);
    }

    public class ForenoonState : State
    {
        public void WriteProgram(Work w)
        {
            if (w.Hour < 12)
                Console.WriteLine("当前时间 {0} 点，上午工作，精神饱满", w.Hour);
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            }
        }
    }

    public class NoonState : State
    {
        public void WriteProgram(Work w)
        {
            if(w.Hour < 13)
                Console.WriteLine("当前时间 {0} 点，饿了", w.Hour);
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }

    public class AfternoonState : State
    {
        public void WriteProgram(Work w)
        {
            if(w.Hour < 17)
                Console.WriteLine("当前时间 {0} 点，下午状态还不错", w.Hour);
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }

    public class EveningState : State
    {
        public void WriteProgram(Work w)
        {
            if (w.Finish)
            {
                w.SetState(new ResetState());
                w.WriteProgram();
            } else if (w.Hour < 21)
                Console.WriteLine("当前时间 {0} 点，加班中", w.Hour);
            else
            {
                w.SetState(new SleepingState());
                w.WriteProgram();
            }
        }
    }

    internal class ResetState : State
    {
        public void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间 {0} 点，下班回家了", w.Hour);
        }
    }

    internal class SleepingState : State
    {
        public void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间 {0} 点，睡着了", w.Hour);
        }
    }

    public class Work
    {
        private int hour;
        private bool finish = false;
        private State current;

        public int Hour { get => hour; set => hour = value; }
        public bool Finish { get => finish; set => finish = value; }

        public void WriteProgram()
        {
            if (hour < 12)
                Console.WriteLine("当前时间 {0} 点，上午工作，精神饱满",hour);
            else if (hour < 13)
                Console.WriteLine("当前时间 {0} 点，饿了", hour);
            else if (hour < 17)
                Console.WriteLine("当前时间 {0} 点，下午状态还不错", hour);
            else
            {
                if (finish)
                    Console.WriteLine("当前时间 {0} 点，下班回家了", hour);
                else
                {
                    if(hour < 21)
                        Console.WriteLine("当前时间 {0} 点，加班中", hour);
                    else
                        Console.WriteLine("当前时间 {0} 点，睡着了", hour);
                }
            }
        }

        public void SetState(State s)
        {
            this.current = s;
        }
    }
}
