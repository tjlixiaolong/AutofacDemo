using System.Linq;

namespace AutofacDemo.MovieFinder
{
   public class MPGMovieLister
    {
        private readonly IMovieFinder _movieFinder;
        //增加了构造函数，参数是IMovieFinder对象
        public MPGMovieLister(IMovieFinder movieFinder)
        {
            _movieFinder = movieFinder;
        }

        public Movie[] GetMPG()
        {
            var allMovies = _movieFinder.FindAll();
            return allMovies.Where(m => m.Name.EndsWith(".MPG")).ToArray();
        }
    }
}
