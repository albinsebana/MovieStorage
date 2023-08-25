using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStorage.Model
{
    internal class Movie
    {
        public string Title { get; set; }

        public Movie(string title)
        {
            Title = title;
        }
    }
}
