using System;
using Unity;

namespace SampleConsoleWithUnity
{
    public interface IFoo
    {
        string Name { get; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.EnableDebugDiagnostic();

            // 同介面,不同實作,用 name 區別
            container.RegisterType<IFoo, Foo1>("Foo1");
            container.RegisterType<IFoo, Foo2>("Foo2");

            container.RegisterType<MainViewModel>();

            // 有建構式參數的註冊方式
            container.RegisterFactory<Func<string, IFoo>>((c, type, name) => c.Resolve<IFoo>(name));

            // 取回實體
            var vm = container.Resolve<MainViewModel>();
        }
    }

    public class MainViewModel
    {
        public MainViewModel(Func<string, IFoo> fooFactory)
        {
            var foo1 = fooFactory.Invoke("Foo1");
            var foo2 = fooFactory.Invoke("Foo2");
        }
    }

    public class Foo1 : IFoo
    {
        public Foo1()
        {
            Name = "Foo1";
        }

        public string Name { get; set; }
    }

    public class Foo2 : IFoo
    {
        public Foo2()
        {
            Name = "Foo2";
        }

        public string Name { get; set; }
    }
}