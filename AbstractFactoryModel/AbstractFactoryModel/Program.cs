using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/**
 * 抽象工厂模式：
 *      提供一个创建一系列相关或依赖对象的接口，而无需指定它们具体的类。
 **/
namespace AbstractFactoryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department dept = new Department();

            IUser iu = DataAccess.CreateUser(DataAccess.ACCESS);
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = DataAccess.CreateDepartment(DataAccess.SQLSERVER);
            id.Insert(dept);
            id.GetDepartment(1);

            Console.WriteLine("\n输入任意键继续...");
            Console.ReadKey();
        }
    }

    class DataAccess
    {
        public const String SQLSERVER = "Sqlserver";
        public const String ACCESS = "Access";
        private static readonly String AssemblyName = "AbstractFactoryModel";

        public static IUser CreateUser(String type)
        {
            StringBuilder className = new StringBuilder();
            className.Append(AssemblyName).Append(".").Append(type).Append("User");
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className.ToString());
        }

        public static IDepartment CreateDepartment(String type)
        {
            StringBuilder className = new StringBuilder();
            className.Append(AssemblyName).Append(".").Append(type).Append("Department");
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className.ToString());
        }
    }

    interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }

    interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int id);
    }

    //interface IFactory
    //{
    //    IUser CreateUser();
    //    IDepartment CreateDepartment();
    //}

    class User
    {
        private int _id;
        private String _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
    }

    class Department
    {
        private int _id;
        private String _deptName;

        public int Id { get => _id; set => _id = value; }
        public string DeptName { get => _deptName; set => _deptName = value; }
    }

    class SqlserverDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine(" 在 SQL Server 中 给 Department 表 增加 一条 记录");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine(" 在 SQL Server 中 根据 ID 得到 Department 表 一条 记录"); return null;
        }
    }

    class SqlserverUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在 SQL Server 中给 User 表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine(" 在 SQL Server 中 根据 ID 得到 User 表 一条 记录");
            return null;
        }
    }

    class AccessUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在 Access 中给 User 表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine(" 在 Access 中 根据 ID 得到 User 表 一条 记录");
            return null;
        }
    }

    class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine(" 在 Access 中 根据 ID 得到 Department 表 一条 记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine(" 在 Access 中 给 Department 表 增加 一条 记录");
        }
    }

    //class SqlServerFactory : IFactory
    //{
    //    public IDepartment CreateDepartment()
    //    {
    //        return new SqlserverDepartment();
    //    }

    //    public IUser CreateUser()
    //    {
    //        return new SqlserverUser();
    //    }
    //}

    //class AccessFactory : IFactory
    //{
    //    public IDepartment CreateDepartment()
    //    {
    //        return new AccessDepartment();
    //    }

    //    public IUser CreateUser()
    //    {
    //        return new AccessUser();
    //    }
    //}
}
