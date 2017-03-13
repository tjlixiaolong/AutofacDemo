using IocDemo.FinderFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocDemo.MovieFinder
{
    public class MPGMovieLister
    {
        public Movie[] GetMPG()
        {
            var finder = MovieFinderFactory.GetFinder();
            var allMovies = finder.FindAll();

            return allMovies.Where(m => m.Name.EndsWith(".MPG")).ToArray();
        }
    }
}
