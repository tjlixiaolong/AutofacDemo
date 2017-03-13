using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocDemo.MovieFinder
{
    interface IMovieFinder
    {
        List<Movie> FindAll();
    }
}
