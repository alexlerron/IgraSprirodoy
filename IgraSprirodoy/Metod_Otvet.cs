using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraSprirodoy
{
    class Metod_Otvet
    {
        public int[,] massOtvet;
        public int StolbOtvet;
        public int StrokaOtvet;
        public Metod_Otvet(int[,] mass, int Row, int Columb)
        {
            massOtvet = mass;
            StolbOtvet = Columb;
            StrokaOtvet = Row;

        }
    }
}
