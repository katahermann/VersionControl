using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Covid19
{
    public partial class View : Form
    {
        Data data;
        public View()
        {
            data = new Data();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] qC = new int[2];
            List<Patient> qP = (from P in data.Patients
                                where P.Nem == 1
                                select new Patient()
                                {
                                    ID = P.ID,
                                    Nem = P.Nem,
                                    Kor = P.Kor,
                                    Kulfold = P.Kulfold,
                                    Erintkez = P.Erintkez,
                                    Tunet = P.Tunet,
                                    Korlatoz = P.Korlatoz,
                                    Teszt = P.Teszt
                                }).ToList();

            qC[0] = (from P in data.Patients
                     where P.Nem == 1 && ((P.Erintkez + P.Korlatoz + P.Kulfold + P.Teszt + P.Tunet) > 2)
                     select new Patient()
                     {
                         ID = P.ID,
                         Nem = P.Nem,
                         Kor = P.Kor,
                         Kulfold = P.Kulfold,
                         Erintkez = P.Erintkez,
                         Tunet = P.Tunet,
                         Korlatoz = P.Korlatoz,
                         Teszt = P.Teszt
                     }).Count();

            qC[1] = (from P in data.Patients
                     where P.Nem == 1 && ((P.Erintkez + P.Korlatoz + P.Kulfold + P.Teszt + P.Tunet) < 3)
                     select new Patient()
                     {
                         ID = P.ID,
                         Nem = P.Nem,
                         Kor = P.Kor,
                         Kulfold = P.Kulfold,
                         Erintkez = P.Erintkez,
                         Tunet = P.Tunet,
                         Korlatoz = P.Korlatoz,
                         Teszt = P.Teszt
                     }).Count();


            dataGridView1.DataSource = qP;
            this.chart1.Series.Clear();
            this.chart1.Titles.Clear();
            string[] seriesArray = { "Pozitív", "Negatív" };
            this.chart1.Titles.Add("Fertőzöttek");
            this.chart1.Palette = ChartColorPalette.BrightPastel;
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.chart1.Series.Add(seriesArray[i]);
                series.Points.Add(qC[i]);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int[] qC =new int[2];
            List<Patient> qP = (from P in data.Patients
                                where P.Nem == 0
                                select new Patient()
                                {
                                    ID = P.ID,
                                    Nem = P.Nem,
                                    Kor = P.Kor,
                                    Kulfold = P.Kulfold,
                                    Erintkez = P.Erintkez,
                                    Tunet = P.Tunet,
                                    Korlatoz = P.Korlatoz,
                                    Teszt = P.Teszt
                                }).ToList();

            qC[1] = (from P in data.Patients
                     where P.Nem == 0 && ((P.Erintkez + P.Korlatoz + P.Kulfold + P.Teszt + P.Tunet) < 3)
                     select new Patient()
                     {
                         ID = P.ID,
                         Nem = P.Nem,
                         Kor = P.Kor,
                         Kulfold = P.Kulfold,
                         Erintkez = P.Erintkez,
                         Tunet = P.Tunet,
                         Korlatoz = P.Korlatoz,
                         Teszt = P.Teszt
                     }).Count();

            qC[0] = (from P in data.Patients
                     where P.Nem == 0 && ((P.Erintkez+P.Korlatoz+P.Kulfold+P.Teszt+P.Tunet)>2)
                     select new Patient()
                     {
                         ID = P.ID,
                         Nem = P.Nem,
                         Kor = P.Kor,
                         Kulfold = P.Kulfold,
                         Erintkez = P.Erintkez,
                         Tunet = P.Tunet,
                         Korlatoz = P.Korlatoz,
                         Teszt = P.Teszt
                     }).Count();

            dataGridView1.DataSource = qP;
            this.chart1.Series.Clear();
            this.chart1.Titles.Clear();
            this.chart1.Palette = ChartColorPalette.BrightPastel;
            string[] seriesArray = { "Pozitív", "Negatív"};
            this.chart1.Titles.Add("Fertőzöttek");
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.chart1.Series.Add(seriesArray[i]);
                series.Points.Add(qC[i]);
            }
        }
    }
}
