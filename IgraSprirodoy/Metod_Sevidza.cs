using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraSprirodoy
{
    public class Metod_Sevidza
    {
        public int[,] massSevidza;
        public int StolbSevidza;
        public int StrokaSevidza;
        public Metod_Sevidza(int[,] mass, int Row, int Columb)
        {
            massSevidza = mass;
            StolbSevidza = Columb;
            StrokaSevidza = Row;
        }
        public int[] maxSevidza()
        {
            int[] maxMass = new int[StolbSevidza];
            int max;
            for (int j = 0; j < StolbSevidza; j++)
            {
                max = int.MinValue;
                for (int i = 0; i < StrokaSevidza; i++)
                {
                    if (max < massSevidza[i, j])
                        max = massSevidza[i, j];
                }
                maxMass[j] = max;
            }
            return maxMass;
        }

        public int[,] ObratnayaSevidza()
        {
            int[,] obrMass = new int[StrokaSevidza, StolbSevidza];
            int[] maxObrSevidza = maxSevidza();

            for (int i = 0; i < StrokaSevidza; i++)
            {
                for (int j = 0; j < StolbSevidza; j++)
                {
                    obrMass[i, j] = maxObrSevidza[j] - massSevidza[i, j];
                }
            }
            return obrMass;
        }

        public int[] minSevidza()
        {
            int[,] obrMass = ObratnayaSevidza();
            int[] MinMass = new int[StrokaSevidza];
            int max;
            for (int i = 0; i < StrokaSevidza; i++)
            {
                max = int.MinValue;
                for (int j = 0; j < StolbSevidza; j++)
                {
                    if (max < obrMass[i, j])
                        max = obrMass[i, j];
                }
                MinMass[i] = max;

            }

            return MinMass;
        }

        public List<int> TheBestSevidza()
        {
            int[] BestSevidza = minSevidza();
            int min;
            min = int.MaxValue;
            BestSevidza = minSevidza();
            for (int j = 0; j < StrokaSevidza; j++)
            {
                if (BestSevidza[j] < min)
                    min = BestSevidza[j];
            }
            List<int> chislaSev = new List<int>();
            for (int j = 0; j < StrokaSevidza; j++)
            {
                if (BestSevidza[j] == min)
                    chislaSev.Add(j);
            }

            return chislaSev;
        }
        
    }

}

