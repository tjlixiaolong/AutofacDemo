using System.Collections.Generic;

namespace NonIocDemo.MovieFinder
{
    public class ListMovieFinder
    {
        public List<Movie> FindAll()
        {
            return new List<Movie>
                      {
                          new Movie
                              {
                                  Name = "Die Hard.wmv"
                              },
                          new Movie
                              {
                                  Name = "My Name is NonIocDemo.MPG"
                              },
                          new Movie
                              {
                                  Name = "My Name is ListMovieFinder.MPG"
                              }
                      };
        }
    }
}
