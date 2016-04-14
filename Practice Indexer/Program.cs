using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Indexer
{
    class Program
    {
        float x, y, z;

        public void myValue(float d)
        {
            x *= d;
            y *= d;
            z *= d;
        }

        public float this[string i]
        {
            set
            {
                switch(i)
                {
                    case "X":
                        x = value;
                        break;
                    case "Y":
                        y = value;
                        break;
                    case "Z":
                        z = value;
                        break;
                }
            }

            get
            {
                switch(i)
                {
                    case "X":
                        return x;
                    case "Y":
                        return y;
                    case "Z":
                        return z;
                }
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Program ob = new Program();
            ob["X"] = 10.0f;
            ob["Y"] = 20.0f;
            ob["Z"] = 30.0f;

            ob.myValue(2);
            Console.WriteLine(ob["Y"]);

            Console.ReadLine();
        }
    }
}
