﻿using System.Collections.Generic;

namespace IocDemo.MovieFinder
{
    public class ListMovieFinder : IMovieFinder
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
                                  Name = "My Name is IocDemo.MPG"
                              },
                          new Movie
                              {
                                  Name = "My Name is ListMovieFinder.MPG"
                              }
                      };
        }
    }
}