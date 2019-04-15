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
        public List<int> MinStolbJurvica()
        {
            int[] JurvicaMin;
            int min;
            min = int.MinValue;
            JurvicaMin = minJurvica();
            for (int j = 0; j < StrokaJurvica; j++)
            {
                if (JurvicaMin[j] > min)
                    min = JurvicaMin[j];
            }
            List<int> chislaMin = new List<int>();
            for (int j = 0; j < StrokaJurvica; j++)
            {
                if (JurvicaMin[j] == min)
                    chislaMin.Add(j);
            }
            return chislaMin;

        }
        public List<int> MaxStolbJurvica()
        {
            int[] JurvicaMax;
            int max;
            max = int.MinValue;
            JurvicaMax = minJurvica();
            for (int j = 0; j < StrokaJurvica; j++)
            {
                if (JurvicaMax[j] > max)
                    max = JurvicaMax[j];
            }
            List<int> chislaMax = new List<int>();
            for (int j = 0; j < StrokaJurvica; j++)
            {
                if (JurvicaMax[j] == max)
                    chislaMax.Add(j);
            }
            return chislaMax;

        }

    }
}
