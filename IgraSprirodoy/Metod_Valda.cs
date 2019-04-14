using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraSprirodoy
{
    public class Metod_Valda
    {
        public int[,] massValda;
        public int StolbValda;
        public int StrokaValda;
        public Metod_Valda(int[,] mass, int Row, int Columb)
        {
            massValda = mass;
            StolbValda = Columb;
            StrokaValda = Row;
        }

        public int[] minValda()
        {
            int[] MinMass = new int[StrokaValda];
            int min;
            for (int i = 0; i < StrokaValda; i++)
            {
                min = int.MaxValue;
                for (int j = 0; j < StolbValda; j++)
                {
                    if (min > massValda[i, j])
                        min = massValda[i, j];
                }
                MinMass[i] = min;

            }

            return MinMass;
        }
        public List<int> TheBestValda()
        {
            int[] BestValda;
            int max;
            max = int.MinValue;
            BestValda = minValda();
            for (int j = 0; j < StrokaValda; j++)
            {
                if (BestValda[j] > max)
                    max = BestValda[j];
            }
            List<int> chisla = new List<int>();
            for (int j = 0; j < StrokaValda; j++)
            {
                if (BestValda[j] == max)
                    chisla.Add(j);
            }
            return chisla;
        }
        
    }


}
