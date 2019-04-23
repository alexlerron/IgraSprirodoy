using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgraSprirodoy
{
    public partial class Form_Reshenie : Form
    {
        int[,] PoleCat;
        int PoleStroki;
        int PoleStolbi;
        int Alpha;
        int indexMax;
        int indexMaxLap;
        double Q;
        public Form_Reshenie(int[,] cat, int Stroki, int Stolbi, int alpha)
        {
            PoleCat = cat;
            PoleStroki = Stroki;
            PoleStolbi = Stolbi;
            Alpha = alpha;
            InitializeComponent();
            Pole_Sevidza = new Metod_Sevidza(PoleCat, PoleStroki, PoleStolbi);
            Pole_Valda = new Metod_Valda(PoleCat, PoleStroki, PoleStolbi);
            Pole_Jurvica = new Metod_Jurvica(PoleCat, PoleStroki, PoleStolbi);
            //Pole_Otvet = new Metod_Otvet(PoleCat, PoleStroki, PoleStolbi);
            Pole_Laplasa = new Metod_Laplasa(PoleCat, PoleStroki, PoleStolbi);
            Metod_Valda_Form();
            Metod_Sevidza_Form();
            Metod_Jurvica_Form();
            Metod_Laplasa_Form();
            Metod_Otvet_Form();
            
        }

        public Metod_Laplasa Pole_Laplasa;
        private void Metod_Laplasa_Form()
        {
            for (int i = 0; i < PoleStroki; i++)
            {
                for (int j = 0; j < PoleStolbi; j++)
                {
                    TextBox Line1 = new TextBox();
                    Line1.Enabled = false;
                    Line1.Size = new Size(50, 50);
                    Line1.Location = new Point(30 + j * Line1.Size.Width, 50 + i * Line1.Size.Height);
                    PanelReshenieLaplasa.Controls.Add(Line1);
                    Line1.Text = PoleCat[i, j].ToString();
                }


            }


            for (int i = 0; i < PoleStroki; i++)
            {
                Label LabelAm = new Label();
                LabelAm.Size = new Size(50, 20);
                LabelAm.Location = new Point(-20, 53 + i * LabelAm.Size.Height);
                PanelReshenieLaplasa.Controls.Add(LabelAm);
                LabelAm.Text = ('A' + (i + 1).ToString());
                LabelAm.TextAlign = ContentAlignment.TopRight;

            }

            for (int j = 0; j < PoleStolbi; j++)
            {
                Label LabelPn = new Label();
                LabelPn.Size = new Size(50, 20);
                LabelPn.Location = new Point(30 + j * LabelPn.Size.Width, 30);
                PanelReshenieLaplasa.Controls.Add(LabelPn);
                LabelPn.Text = ('P' + (j + 1).ToString());
                LabelPn.TextAlign = ContentAlignment.MiddleCenter;
            }

             Q = (1.0 / PoleStolbi);

            double[] Summlaplasa = new double[PoleStroki];

            for (int j = 0; j < PoleStroki; j++)
            {
                for (int i = 0; i < PoleStolbi; i++)
                {
                    Summlaplasa[j] += PoleCat[j,i];
                }
                
            }

            double[] Alaplasa = new double[PoleStroki];
            double maxLap = Summlaplasa.Max();
            indexMaxLap = Array.IndexOf(Summlaplasa, maxLap);
            for (int j = 0; j < PoleStroki; j++)
            {
                Alaplasa[j] = (Summlaplasa[j] * Q);


                TextBox LineLaplasa = new TextBox();
                LineLaplasa.Enabled = false;
                LineLaplasa.Size = new Size(50, 50);
                LineLaplasa.Location = new Point((PoleStolbi + 1) * 46 , 50 + j * LineLaplasa.Size.Height);
                PanelReshenieLaplasa.Controls.Add(LineLaplasa);
                LineLaplasa.Text = Alaplasa[j].ToString();
                LineLaplasa.BackColor = Color.LightGoldenrodYellow;
                Label LabelLaplasa = new Label();
                LabelLaplasa.Size = new Size(50, 50);
                LabelLaplasa.Location = new Point((PoleStolbi + 1) *46 , 15);
                PanelReshenieLaplasa.Controls.Add(LabelLaplasa);
                LabelLaplasa.Text = ("Lap");
                LabelLaplasa.TextAlign = ContentAlignment.MiddleCenter;
                if (j == indexMaxLap)
                    LineLaplasa.BackColor = Color.Red;
            }
        }
        private void Metod_Otvet_Form()
        {
            List<int> sev = Pole_Sevidza.TheBestSevidza();
            List<int> vald = Pole_Valda.TheBestValda();
            int jurv = indexMax;
            double LapWin = indexMaxLap;


            string str_sev = "Метод Севиджа:";
            for (int i = 0; i < sev.Count; i++)
            {
                str_sev += " A" + (sev[i] + 1).ToString();
            }
            string str_vald = "Метод Вальда:";
            for (int i = 0; i < vald.Count; i++)
            {
                str_vald += " A" + (vald[i] + 1).ToString();
            }
            string str_jurv = "Метод Гурвица: A" + (jurv+1).ToString();
            string str_lap = "Метод Лапласа: А" + (LapWin+1).ToString();

            label_WinSev.Text = str_sev;
            label_WinJurv.Text = str_jurv;
            label_WinValda.Text = str_vald;
            label_WinLaplasa.Text = str_lap;

        }

        public Metod_Sevidza Pole_Sevidza;
        private void Metod_Sevidza_Form()
        {
            for (int i = 0; i < PoleStroki; i++)
            {
                for (int j = 0; j < PoleStolbi; j++)
                {
                    TextBox Line1 = new TextBox();
                    Line1.Enabled = false;
                    Line1.Size = new Size(50, 50);
                    Line1.Location = new Point(30 + j * Line1.Size.Width, 50 + i * Line1.Size.Height);
                    PanelReshenieSevidza.Controls.Add(Line1);
                    Line1.Text = PoleCat[i, j].ToString();
                }


            }


            for (int i = 0; i < PoleStroki; i++)
            {
                Label LabelAm = new Label();
                LabelAm.Size = new Size(50, 20);
                LabelAm.Location = new Point(-20, 53 + i * LabelAm.Size.Height);
                PanelReshenieSevidza.Controls.Add(LabelAm);
                LabelAm.Text = ('A' + (i + 1).ToString());
                LabelAm.TextAlign = ContentAlignment.TopRight;

            }

            for (int j = 0; j < PoleStolbi; j++)
            {
                Label LabelPn = new Label();
                LabelPn.Size = new Size(50, 20);
                LabelPn.Location = new Point(30 + j * LabelPn.Size.Width, 30);
                PanelReshenieSevidza.Controls.Add(LabelPn);
                LabelPn.Text = ('P' + (j + 1).ToString());
                LabelPn.TextAlign = ContentAlignment.MiddleCenter;
            }

            int[] MaxASev = Pole_Sevidza.maxSevidza();
            List<int> indexes = Pole_Sevidza.TheBestSevidza();
            for (int k = 0; k < PoleStolbi; k++)
            {
                TextBox Line3 = new TextBox();
                Line3.Enabled = false;
                Line3.Size = new Size(50, 50);
                Line3.Location = new Point(30 + k * Line3.Size.Width, 50 + PoleStroki * Line3.Size.Height);
                PanelReshenieSevidza.Controls.Add(Line3);
                Line3.Text = MaxASev[k].ToString();
                Line3.BackColor = Color.AliceBlue;

            }
            int[,] obrMass = Pole_Sevidza.ObratnayaSevidza();

            for (int i = 0; i < PoleStroki; i++)
            {
                for (int j = 0; j < PoleStolbi; j++)
                {
                    TextBox LineObrSev = new TextBox();
                    LineObrSev.Enabled = false;
                    LineObrSev.Size = new Size(50, 50);
                    LineObrSev.Location = new Point(PoleStolbi * 50 + 100 + j * LineObrSev.Size.Width, 50 + i * LineObrSev.Size.Height);
                    PanelReshenieSevidza.Controls.Add(LineObrSev);
                    LineObrSev.Text = obrMass[i, j].ToString();
                }
            }

            for (int i = 0; i < PoleStroki; i++)
            {
                Label LabelAm = new Label();
                LabelAm.Size = new Size(50, 20);
                LabelAm.Location = new Point(PoleStolbi * 50 + 50, 53 + i * LabelAm.Size.Height);
                PanelReshenieSevidza.Controls.Add(LabelAm);
                LabelAm.Text = ('A' + (i + 1).ToString());
                LabelAm.TextAlign = ContentAlignment.TopRight;

            }

            for (int j = 0; j < PoleStolbi; j++)
            {
                Label LabelPn = new Label();
                LabelPn.Size = new Size(50, 20);
                LabelPn.Location = new Point(PoleStolbi * 50 + 100 + j * LabelPn.Size.Width, 30);
                PanelReshenieSevidza.Controls.Add(LabelPn);
                LabelPn.Text = ('P' + (j + 1).ToString());
                LabelPn.TextAlign = ContentAlignment.MiddleCenter;
            }

            int[] WinSavi = Pole_Sevidza.minSevidza();
            List<int> indexess = Pole_Sevidza.TheBestSevidza();
            for (int k = 0; k < PoleStroki; k++)
            {
                TextBox Line4 = new TextBox();
                Line4.Enabled = false;
                Line4.Size = new Size(50, 50);
                Line4.Location = new Point(PoleStolbi * 50 + 100 + PoleStolbi * 50, 50 + k * Line4.Size.Height);
                PanelReshenieSevidza.Controls.Add(Line4);
                Line4.Text = WinSavi[k].ToString();
                if (indexess.Contains(k))
                {
                    Line4.BackColor = Color.Yellow;
                }

            }
            Label LabelWinSavidza = new Label();
            LabelWinSavidza.Size = new Size(50, 50);
            LabelWinSavidza.Location = new Point(30 + PoleStolbi * 50, 15);
            PanelReshenieValda.Controls.Add(LabelWinSavidza);
            LabelWinSavidza.Text = ("Max");
            LabelWinSavidza.TextAlign = ContentAlignment.MiddleCenter;
        }

        public Metod_Valda Pole_Valda;

        public void Metod_Valda_Form()
        {
            for (int i = 0; i < PoleStroki; i++)
            {
                for (int j = 0; j < PoleStolbi; j++)
                {
                    TextBox Line1 = new TextBox();
                    Line1.Enabled = false;
                    Line1.Size = new Size(50, 50);
                    Line1.Location = new Point(30 + j * Line1.Size.Width, 50 + i * Line1.Size.Height);
                    PanelReshenieValda.Controls.Add(Line1);
                    Line1.Text = PoleCat[i, j].ToString();
                }


            }


            for (int i = 0; i < PoleStroki; i++)
            {
                Label LabelAm = new Label();
                LabelAm.Size = new Size(50, 20);
                LabelAm.Location = new Point(-20, 53 + i * LabelAm.Size.Height);
                PanelReshenieValda.Controls.Add(LabelAm);
                LabelAm.Text = ('A' + (i + 1).ToString());
                LabelAm.TextAlign = ContentAlignment.TopRight;

            }

            for (int j = 0; j < PoleStolbi; j++)
            {
                Label LabelPn = new Label();
                LabelPn.Size = new Size(50, 20);
                LabelPn.Location = new Point(30 + j * LabelPn.Size.Width, 30);
                PanelReshenieValda.Controls.Add(LabelPn);
                LabelPn.Text = ('P' + (j + 1).ToString());
                LabelPn.TextAlign = ContentAlignment.MiddleCenter;
            }

            int[] min = Pole_Valda.minValda();
            List<int> indexes = Pole_Valda.TheBestValda();
            for (int k = 0; k < PoleStroki; k++)
            {
                TextBox Line2 = new TextBox();
                Line2.Enabled = false;
                Line2.Size = new Size(50, 50);
                Line2.Location = new Point(30 + PoleStolbi * 50, 50 + k * Line2.Size.Height);
                PanelReshenieValda.Controls.Add(Line2);
                Line2.Text = min[k].ToString();
                if (indexes.Contains(k))
                {
                    Line2.BackColor = Color.Yellow;
                }
                Label LabelWinValda = new Label();
                LabelWinValda.Size = new Size(50, 50);
                LabelWinValda.Location = new Point(30 + PoleStolbi * 50, 15);
                PanelReshenieValda.Controls.Add(LabelWinValda);
                LabelWinValda.Text = ("Min");
                LabelWinValda.TextAlign = ContentAlignment.MiddleCenter;
            }


        }

        public Metod_Jurvica Pole_Jurvica;

        public void Metod_Jurvica_Form()
        {
            for (int i = 0; i < PoleStroki; i++)
            {
                for (int j = 0; j < PoleStolbi; j++)
                {
                    TextBox Line5 = new TextBox();
                    Line5.Enabled = false;
                    Line5.Size = new Size(50, 50);
                    Line5.Location = new Point(30 + j * Line5.Size.Width, 50 + i * Line5.Size.Height);
                    PanelReshenieJuvica.Controls.Add(Line5);
                    Line5.Text = PoleCat[i, j].ToString();
                }


            }

            for (int i = 0; i < PoleStroki; i++)
            {
                Label LabelAm = new Label();
                LabelAm.Size = new Size(50, 20);
                LabelAm.Location = new Point(-20, 53 + i * LabelAm.Size.Height);
                PanelReshenieJuvica.Controls.Add(LabelAm);
                LabelAm.Text = ('A' + (i + 1).ToString());
                LabelAm.TextAlign = ContentAlignment.TopRight;

            }

            for (int j = 0; j < PoleStolbi; j++)
            {
                Label LabelPn = new Label();
                LabelPn.Size = new Size(50, 20);
                LabelPn.Location = new Point(30 + j * LabelPn.Size.Width, 30);
                PanelReshenieJuvica.Controls.Add(LabelPn);
                LabelPn.Text = ('P' + (j + 1).ToString());
                LabelPn.TextAlign = ContentAlignment.MiddleCenter;
            }

            int[] minJur = Pole_Jurvica.minJurvica();
            for (int k = 0; k < PoleStroki; k++)
            {
                TextBox LineMinJur = new TextBox();
                LineMinJur.Enabled = false;
                LineMinJur.Size = new Size(50, 50);
                LineMinJur.Location = new Point(30 + PoleStolbi * 50, 50 + k * LineMinJur.Size.Height);
                PanelReshenieJuvica.Controls.Add(LineMinJur);
                LineMinJur.Text = minJur[k].ToString();
                LineMinJur.BackColor = Color.GreenYellow;
                Label LabelMinJur = new Label();
                LabelMinJur.Size = new Size(50, 50);
                LabelMinJur.Location = new Point(30 + PoleStolbi * 50, 15);
                PanelReshenieJuvica.Controls.Add(LabelMinJur);
                LabelMinJur.Text = ("Min");
                LabelMinJur.TextAlign = ContentAlignment.MiddleCenter;
            }

            int[] maxJur = Pole_Jurvica.maxJurvica();
            for (int k = 0; k < PoleStroki; k++)
            {
                TextBox LineMaxJur = new TextBox();
                LineMaxJur.Enabled = false;
                LineMaxJur.Size = new Size(50, 50);
                LineMaxJur.Location = new Point(30 + (PoleStolbi + 1) * 50, 50 + k * LineMaxJur.Size.Height);
                PanelReshenieJuvica.Controls.Add(LineMaxJur);
                LineMaxJur.Text = maxJur[k].ToString();
                LineMaxJur.BackColor = Color.IndianRed;
                Label LabelMaxJur = new Label();
                LabelMaxJur.Size = new Size(50, 50);
                LabelMaxJur.Location = new Point(30 + (PoleStolbi + 1) * 50, 15);
                PanelReshenieJuvica.Controls.Add(LabelMaxJur);
                LabelMaxJur.Text = ("Max");
                LabelMaxJur.TextAlign = ContentAlignment.MiddleCenter;
            }

            double[] MaxAlphaJur = new double[PoleStroki];

            for (int j = 0; j < PoleStroki; j++)
            {
                MaxAlphaJur[j] = (maxJur[j] * (100 - Alpha) / 100f);
                TextBox LineAlphaJurM = new TextBox();
                LineAlphaJurM.Enabled = false;
                LineAlphaJurM.Size = new Size(50, 50);
                LineAlphaJurM.Location = new Point(30 + (PoleStolbi + 3) * 50, 50 + j * LineAlphaJurM.Size.Height);
                PanelReshenieJuvica.Controls.Add(LineAlphaJurM);
                LineAlphaJurM.Text = MaxAlphaJur[j].ToString();
                LineAlphaJurM.BackColor = Color.LightSteelBlue;
                Label LabelAlphaJurM = new Label();
                LabelAlphaJurM.Size = new Size(50, 50);
                LabelAlphaJurM.Location = new Point(30 + (PoleStolbi + 3) * 50, 15);
                PanelReshenieJuvica.Controls.Add(LabelAlphaJurM);
                LabelAlphaJurM.Text = ("Max*λ");
                LabelAlphaJurM.TextAlign = ContentAlignment.MiddleCenter;
            }
            double[] MinAlphaJur = new double[PoleStroki];

            for (int j = 0; j < PoleStroki; j++)
            {
                MinAlphaJur[j] = (minJur[j] * Alpha) / 100f;
                TextBox LineAlphaJur = new TextBox();
                LineAlphaJur.Enabled = false;
                LineAlphaJur.Size = new Size(50, 50);
                LineAlphaJur.Location = new Point(30 + (PoleStolbi + 2) * 50, 50 + j * LineAlphaJur.Size.Height);
                PanelReshenieJuvica.Controls.Add(LineAlphaJur);
                LineAlphaJur.Text = MinAlphaJur[j].ToString();
                LineAlphaJur.BackColor = Color.LightGoldenrodYellow;
                Label LabelAlphaJur = new Label();
                LabelAlphaJur.Size = new Size(50, 50);
                LabelAlphaJur.Location = new Point(30 + (PoleStolbi + 2) * 50, 15);
                PanelReshenieJuvica.Controls.Add(LabelAlphaJur);
                LabelAlphaJur.Text = ("Min*λ");
                LabelAlphaJur.TextAlign = ContentAlignment.MiddleCenter;
            }

            double[] SummAlphaJur = new double[PoleStroki];
            for (int j = 0; j < PoleStroki; j++)
            {
                SummAlphaJur[j] = (MinAlphaJur[j] + MaxAlphaJur[j]);
            }
            double max = SummAlphaJur.Max();
            indexMax = Array.IndexOf(SummAlphaJur, max);

            for (int j = 0; j < PoleStroki; j++)
            {
                TextBox LineAlphaJurSumm = new TextBox();
                LineAlphaJurSumm.Enabled = false;
                LineAlphaJurSumm.Size = new Size(50, 50);
                LineAlphaJurSumm.Location = new Point(30 + (PoleStolbi + 4) * 50, 50 + j * LineAlphaJurSumm.Size.Height);
                PanelReshenieJuvica.Controls.Add(LineAlphaJurSumm);
                LineAlphaJurSumm.Text = (SummAlphaJur[j]).ToString();
                LineAlphaJurSumm.BackColor = Color.MediumSeaGreen;
                Label LabelAlphaJurSumm = new Label();
                LabelAlphaJurSumm.Size = new Size(50, 50);
                LabelAlphaJurSumm.Location = new Point(30 + (PoleStolbi + 4) * 50, 15);
                PanelReshenieJuvica.Controls.Add(LabelAlphaJurSumm);
                LabelAlphaJurSumm.Text = ("+");
                LabelAlphaJurSumm.TextAlign = ContentAlignment.MiddleCenter;
                if (j == indexMax)
                    LineAlphaJurSumm.BackColor = Color.Red;
            }
        }

        private void Form_Reshenie_Load(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label_WinLaplasa_Click(object sender, EventArgs e)
        {

        }

        private void Label_WinJurv_Click(object sender, EventArgs e)
        {

        }
    }
}