using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    class Movie
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int idmovie;
        public int IdMovie
        {
            get { return idmovie; }
            set { idmovie = value; }
        }

        public string duration;
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

    }
}
