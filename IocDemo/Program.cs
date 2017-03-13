using IocDemo.MovieFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocDemo
{
    class Program
    {
        //完成了IOC（控制反转），控制权最初取决于MPGMovieLister中如何实例化MovieFinder的，现在交出控制权，交由
        //外部类MovieFinderFactory来提供具体实例对象，MovieFinderFactory就已经是个简陋的IOC容器了。
        //IOC控制反转是一个重要的面向对象编程法则，来削减计算机程序耦合问题。比如电脑的USB接口，只要符合USB标准的
        //外设,就能够接上电脑使用。
        static void Main(string[] args)
        {
            var lister = new MPGMovieLister();

            foreach (var movie in lister.GetMPG())
            {
                Console.WriteLine(movie.Name);
            }
            Console.Read();
        }
    }
}
