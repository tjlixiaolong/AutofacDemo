﻿using System.Collections.Generic;

namespace AutofacDemo.MovieFinder
{
    public class DBMovieFinder : IMovieFinder
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
                                  Name = "My Name is AutofacDemo.MPG"
                             },
                          new Movie
                              {
                                  Name = "My Name is DBMovieFinder.MPG"
                              }
                       };
        }
    }
}
