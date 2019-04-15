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
            Metod_Valda_Form();
            Metod_Sevidza_Form();
            Metod_Jurvica_Form();
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
            int indexMax = Array.IndexOf(SummAlphaJur, max);

            for (int j = 0; j < PoleStroki; j++)
            {
                TextBox LineAlphaJurSumm = new TextBox();
                LineAlphaJurSumm.Enabled = false;
                LineAlphaJurSumm.Size = new Size(50, 50);
                LineAlphaJurSumm.Location = new Point(30 + (PoleStolbi + 4) * 50, 50 + j * LineAlphaJurSumm.Size.Height);
                PanelReshenieJuvica.Controls.Add(LineAlphaJurSumm);
                LineAlphaJurSumm.Text = (SummAlphaJur[j]).ToString();
                LineAlphaJurSumm.BackColor = Color.LightGoldenrodYellow;
                Label LabelAlphaJurSumm = new Label();
                LabelAlphaJurSumm.Size = new Size(50, 50);
                LabelAlphaJurSumm.Location = new Point(30 + (PoleStolbi + 4) * 50, 15);
                PanelReshenieJuvica.Controls.Add(LabelAlphaJurSumm);
                LabelAlphaJurSumm.Text = ("+");
                LabelAlphaJurSumm.TextAlign = ContentAlignment.MiddleCenter;
                if (j == indexMax)
                    LineAlphaJurSumm.BackColor = Color.Red;
            }

            //int[] minSev = Pole_Jurvica.minJurvica();
            //List<int> indexes = Pole_Jurvica.MinStolbJurvica();
            //for (int k = 0; k < PoleStroki; k++)
            //{
            //    TextBox LineMinJur = new TextBox();
            //    LineMinJur.Enabled = false;
            //    LineMinJur.Size = new Size(50, 50);
            //    LineMinJur.Location = new Point(30 + PoleStolbi * 50, 50 + k * LineMinJur.Size.Height);
            //    PanelReshenieJuvica.Controls.Add(LineMinJur);
            //    LineMinJur.Text = minSev[k].ToString();
            //    LineMinJur.BackColor = Color.GreenYellow;
            //    Label LabelMinJur = new Label();
            //    LabelMinJur.Size = new Size(50, 50);
            //    LabelMinJur.Location = new Point(30 + PoleStolbi * 50, 15);
            //    PanelReshenieJuvica.Controls.Add(LabelMinJur);
            //    LabelMinJur.Text = ("Min");
            //    LabelMinJur.TextAlign = ContentAlignment.MiddleCenter;
            //}

            //int[] maxSev = Pole_Jurvica.maxJurvica();
            //List<int> indexesmax = Pole_Jurvica.MaxStolbJurvica();
            //for (int k = 0; k < PoleStroki; k++)
            //{
            //    TextBox LineMaxJur = new TextBox();
            //    LineMaxJur.Enabled = false;
            //    LineMaxJur.Size = new Size(50, 50);
            //    LineMaxJur.Location = new Point(30 + PoleStolbi+1 * 50, 50 + k * LineMaxJur.Size.Height);
            //    PanelReshenieJuvica.Controls.Add(LineMaxJur);
            //    LineMaxJur.Text = maxSev[k].ToString();
            //    LineMaxJur.BackColor = Color.GreenYellow;
            //    Label LabelMaxJur = new Label();
            //    LabelMaxJur.Size = new Size(50, 50);
            //    LabelMaxJur.Location = new Point(30 + PoleStolbi * 50, 15);
            //    PanelReshenieJuvica.Controls.Add(LabelMaxJur);
            //    LabelMaxJur.Text = ("Max");
            //    LabelMaxJur.TextAlign = ContentAlignment.MiddleCenter;
            //}

        }




        private void Form_Reshenie_Load(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
