using IocDemo.MovieFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocDemo.FinderFactory
{
    class MovieFinderFactory
    {
        public static IMovieFinder GetFinder()
        {
            return new DBMovieFinder();
        }
    }
}
