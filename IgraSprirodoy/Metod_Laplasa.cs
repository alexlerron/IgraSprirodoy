namespace IgraSprirodoy
{
    public class Metod_Laplasa
    {
        public int[,] massLaplasa;
        public int StolbLaplasa;
        public int StrokaLaplasa;
        public Metod_Laplasa(int[,] mass, int Columb, int Row)
        {
            massLaplasa = mass;
            StolbLaplasa = Columb;
            StrokaLaplasa = Row;
        }

    }


}
