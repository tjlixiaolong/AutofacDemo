using System;
using AutofacDemo.MovieFinder;
using Autofac;
//using FakeAutofac;

namespace AutofacDemo
{
    internal class Program
    {
        private static IContainer _container;
        //让Autofac作为不同层之间的中间人，让UI层依赖于业务逻辑层的抽象接口，业务逻辑层依赖于抽象层的接口，
        //而实际运行过程中的实例都由Autofac来提供。这样就解除了不同层之间的依赖，将所有注册类型的操作在一个核心
        //函数或者核心类中实现，那么只要修改这个函数或者类，就能够非常方便的让他们之间依赖关系发生改变。
        private static void Main(string[] args)
        {
            InitIoC();

            var lister = _container.Resolve<MPGMovieLister>();

            foreach (var movie in lister.GetMPG())
            {
                Console.WriteLine(movie.Name);
            }
            Console.Read();
        }


        private static void InitIoC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ListMovieFinder>().AsImplementedInterfaces();
            //builder.RegisterType<DBMovieFinder>().AsImplementedInterfaces();
            builder.RegisterType<MPGMovieLister>();
            _container = builder.Build();
        }
    }
}
