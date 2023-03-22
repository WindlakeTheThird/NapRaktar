using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_library
{
    public class Worker
    {
        public static int Id { get; set; }
        public static string Nev { get; set; }

        public Worker(int id, string nev)
        {
            Id = id;
            Nev = nev;
        }
        public Worker()
        {
        }

    }
}
