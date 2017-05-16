using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UndergraduateFactory();
            LeiFeng student = factory.CreateLeiFeng();
        }
    }

    class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("扫地");
        }

        public void Wash()
        {
            Console.WriteLine("洗衣");
        }

        public void BuyRice()
        {
            Console.WriteLine("买米");
        }
    }

    class Undergraduate:LeiFeng
    {

    }

    class Volunteer:LeiFeng
    {

    }

    interface IFactory
    {
        LeiFeng CreateLeiFeng();
    }

    class UndergraduateFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }

    class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}
