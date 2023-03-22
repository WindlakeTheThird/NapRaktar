using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_library
{
    public class Part
    {

        public int Id { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public double Unit_cost { get; set; }

        public Part(int id, string type, int amount, double unit_cost)
        {
            Id = id;
            Type = type;
            Amount = amount;
            Unit_cost = unit_cost;
        }
        public Part()
        {
        }
    }
}
