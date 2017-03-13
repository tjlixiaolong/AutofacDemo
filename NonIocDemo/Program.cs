using NonIocDemo.MovieFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonIocDemo
{
    class Program
    {
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
