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
    public partial class Form1 : Form
    {
        int Am;
        int Pn;
        int Alpha;
        TextBox[,] mass;
        Label[] LabAm;
        Label[] LabPn;
        public Form1()
        {
            InitializeComponent();
            Alpha = int.Parse(textBox_Alpha.Text);
            
        }

        private void Button_GenMatrix_Click(object sender, EventArgs e)// генерация матрицы
        {
            for (int i = 0; i < Am; i++)
            {
                for (int j = 0; j <Pn; j++)
                {
                    this.Controls.Remove(mass[i, j]);
                }
            }
            Am = int.Parse(textBox_Am.Text);
            Pn = int.Parse(textBox_Pn.Text);
            mass = new TextBox[Am, Pn];
            Random rand = new Random();

            for (int i = 0; i < Am; i++)
            {
                for (int j = 0; j < Pn; j++)
                {
                    TextBox Line1 = new TextBox();
                    mass[i, j] = Line1;
                    Line1.Size = new Size(50, 50);
                    Line1.Location = new Point(100 + j * Line1.Size.Width, 100 + i * Line1.Size.Height);
                    Controls.Add(Line1);
                    Line1.Text = rand.Next(20).ToString();
                }


            }
            LabAm = new Label[Am];
            LabPn = new Label[Pn];
            for (int i = 0; i < Am; i++)
            {
                Label LabelAm = new Label();
                LabAm[i] = LabelAm;
                LabelAm.Size = new Size(50, 20);
                LabelAm.Location = new Point(50, 103 + i * LabelAm.Size.Height);
                Controls.Add(LabelAm);
                LabelAm.Text = ('A' + (i+1).ToString());
                LabelAm.TextAlign = ContentAlignment.TopRight;

            }
            for (int j = 0; j < Pn; j++)
            {
                Label LabelPn = new Label();
                LabPn[j] = LabelPn;
                LabelPn.Size = new Size(50, 20);
                LabelPn.Location = new Point(100 + j * LabelPn.Size.Width, 80 );
                Controls.Add(LabelPn);
                LabelPn.Text = ('P' + (j + 1).ToString());
                LabelPn.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void TextBox_Am_TextChanged(object sender, EventArgs e)
        {

        }// Am

        private void TextBox_Pn_TextChanged(object sender, EventArgs e)
        {

        }// Pn

        private void Methods_Click(object sender, EventArgs e) // Решение
        {
            Alpha = int.Parse(textBox_Alpha.Text);
            if (Alpha > 99)
            {
                MessageBox.Show("Недопустимое значение Alpha");
            }
            int[,] MassivResh;
            MassivResh = new int[Am,Pn];
            for (int i = 0; i < Am; i++)
            {
                for (int j = 0; j < Pn; j++)
                {
                    MassivResh[i, j] = Convert.ToInt32(mass[i, j].Text);
                }

            }
            Form_Reshenie Mya = new Form_Reshenie(MassivResh, Am, Pn, Alpha);
            Mya.Show();
           
        }

        private void TextBox_Alpha_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
