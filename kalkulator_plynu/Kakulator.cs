using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator_plynu
{
    public class Kakulator
    {
        public int volume { get; set; }
        public double percent { get; set; }
        public int count { get; set; }

        public Kakulator(int volume, double percent, int count)
        {
            this.volume = volume;
            this.percent = percent;
            this.count = count;
        }
         
        public double caculate (double totalVolume)
        {
            double total = (volume * (percent / 100)) * count;
            return total;
        }

        public static readonly Dictionary<string, int> volumeMapping = new Dictionary<string, int>
        {
            { "Kieliszek 150", 150 },
            { "Szklanka 250", 250 },
            { "Kubek 300", 300 },
            { "Butelka 500", 500 }
        };
        public static readonly Dictionary<string,int> keySolution= new Dictionary<string, int>
        {
            {"Roztwor soli 10", 10 },
            {"Roztwor cukru 8", 8 },
            {"Roztwor alkoholu 40", 40 },
            {"Woda c octem 5", 5 }

        };

    }
}
