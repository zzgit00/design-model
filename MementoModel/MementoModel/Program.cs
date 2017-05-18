using System;

/**
 * 备忘录模式：
 *      在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。
 *      这样以后就可将该对象恢复到原先保存的状态。
 **/
namespace MementoModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";
            o.Show();

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";
            o.Show();

            o.SetMemento(c.Memento);
            o.Show();

            Console.WriteLine("\n按下任意键继续...");
            Console.ReadKey();
        }
    }

    class Originator
    {
        private String state;

        public string State { get => state; set => state = value; }

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }

        public void Show()
        {
            Console.WriteLine("State="+state);
        }
    }

    public class Memento
    {
        private string state;

        public string State { get => state; set => state = value; }

        public Memento(string state)
        {
            this.State = state;
        }
    }

    class Caretaker
    {
        private Memento memento;

        public Memento Memento { get => memento; set => memento = value; }
    }
}
