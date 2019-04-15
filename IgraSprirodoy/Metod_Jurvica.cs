using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraSprirodoy
{
    public class Metod_Jurvica
    {
        public int[,] massJurvica;
        public int StolbJurvica;
        public int StrokaJurvica;
        public Metod_Jurvica(int[,] mass, int Row, int Columb)
        {
            massJurvica = mass;
            StolbJurvica = Columb;
            StrokaJurvica = Row;
            
        }
        public int[] minJurvica()
        {
            int[] MinMassJur = new int[StrokaJurvica];
            int min;
            for (int i = 0; i < StrokaJurvica; i++)
            {
                min = int.MaxValue;
                for (int j = 0; j < StolbJurvica; j++)
                {
                    if (min > massJurvica[i, j])
                        min = massJurvica[i, j];
                }
                MinMassJur[i] = min;

            }

            return MinMassJur;
        }
        public int[] maxJurvica()
        {
            int[] maxMassJur = new int[StolbJurvica];
            int max;
            for (int i = 0; i < StolbJurvica; i++)
            {
                max = int.MinValue;
                for (int j = 0; j < StrokaJurvica; j++)
                {
                    if (max < massJurvica[i, j])
                        max = massJurvica[i, j];
                }
                maxMassJur[i] = max;
            }
            return maxMassJur;
        }

        
    }

}
