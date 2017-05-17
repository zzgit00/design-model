using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 原型模式：
 *      用原型实例指定创建对象的类种类，并且通过拷贝这些原型创建新的对象。
 */
namespace PrototypeModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("小白");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2002", "XX 公司");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2006", "YY 公司");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("男", "24");
            c.SetWorkExperience("1991-2000", "ZZ 公司");

            a.Display();
            b.Display();
            c.Display();

            Console.WriteLine("输入任意键继续...");
            Console.ReadKey();
        }
    }

    class WorkExperience : ICloneable
    {
        private String workDate;

        public String WorkDate
        {
            get { return workDate; }
            set { workDate = value; }
        }

        private String company;
        public String Company
        {
            get { return company; }
            set { company = value; }
        }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    class Resume : ICloneable
    {
        private String name;
        private String sex;
        private String age;
        private WorkExperience work;

        public Resume(String name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        private Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(String sex, String age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(String workDate, String company)
        {
            work.WorkDate = workDate;
            work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}",name,sex,age);
            Console.WriteLine("工作经历：{0} {1}", work.WorkDate, work.Company);
        }

        public object Clone()
        {
            Resume resume = new Resume(this.work);
            resume.name = this.name;
            resume.sex = this.sex;
            resume.age = this.age;

            return resume;
        }
    }
}
