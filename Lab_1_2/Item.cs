using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    internal class Item
    {
        public int number { get; }
        public double value { get; }
        public double weight { get; }
        public double ratio { get; }

        public Item(int nr = 0, double val = 0, double weigh = 0) {
            if (nr < 0 || val < 0 || weigh < 0)
            {
                number = 0;
                value = 0;
                weight = 0;
                ratio = 0;
            }
            else
            {
                number = nr;
                value = val;
                weight = weigh;
                ratio = value / weigh;
            }
        }

        public override string ToString()
        {
            return "Numer: " + number + " Wartość: " + value + " Waga: " + weight + " Stosunek: " + ratio.ToString("0.00");
        }
    }
}
