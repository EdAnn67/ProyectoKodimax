using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    class Snacks
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int idsnack;
        public int IdSnack
        {
            get { return idsnack; }
            set { idsnack = value; }
        }

        public double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }


        public string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
