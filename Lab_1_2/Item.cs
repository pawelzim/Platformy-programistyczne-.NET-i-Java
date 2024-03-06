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

        public Item(int nr, double val, double weigh) {
            number = nr;
            value = val;
            weight = weigh;
            ratio = value / weigh;
        }

        public override string ToString()
        {
            return "Numer: " + number + " Wartosc: " + value + " Waga: " + weight + " Współczynnik: " + ratio;
        }
    }
}
