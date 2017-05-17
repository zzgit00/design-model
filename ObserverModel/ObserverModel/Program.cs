using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 观察者模式：
 *      定义了一种一对多的依赖关系，让多个观察者对象同时监听某一个主题对象。
 *      这个主题对象在状态发生变化时，会通知所有观察者对象，使它们能够自动更新自己。
 **/
namespace ObserverModel
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            s.SubjectState = "ABC";
            s.Notify();

            Console.WriteLine("\n按下任意键继续...");
            Console.ReadKey();
        }
    }

    interface Observer
    {
        void Update();
    }

    abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in observers)
                o.Update();
        }
    }

    class ConcreteSubject : Subject
    {
        private String subjectState;

        public String SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }

    class ConcreteObserver : Observer
    {
        private String name;
        private String observerState;
        private ConcreteSubject subject;
        
        public ConcreteObserver(ConcreteSubject subject,String name)
        {
            this.subject = subject;
            this.name = name;
        }

        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("观察者 {0} 的新状态是 {1}", name, observerState);
        }


    }
}
