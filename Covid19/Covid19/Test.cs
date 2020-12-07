using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19
{
    public partial class Test : Form
    {
        private TextBox textBox1;
        public Test()
        {
            InitializeComponent();
            CreateQField();
        }


        private void CreateQField()
        {
            int lineWidth = 5;
            string[] names = { "Adja meg a korát!", "Adja meg a nemét!", "Jártál-e külföldön az elmúlt 14 napban?", "Érintkeztél koronavírusos beteggel az elmúlt 14 napban?", "Tapasztaltál-e magadon koronavírusra utaló tüneteket?", "Megszegted-e a kormány által megszabott korlátozásokat?", "Rendelkezel pozitív PCR teszttel?", };
            panel1.Controls.Add(new TextBox() { Name = "Kor", Margin = new System.Windows.Forms.Padding(10, 20, 0, 0), Text = "20", Height = 30, Width = 47, Top = 8, Left = 326 });
            for (int r = 1; r < 7; r++)
            {
                if(r == 1)
                {
                    GenderField gf = new GenderField();
                    gf.Top = r * gf.Height + (int)(Math.Floor((double)(r / 3))) * lineWidth;
                    gf.Left = gf.Width + (int)(Math.Floor((double)(55))) * lineWidth;
                    panel1.Controls.Add(gf);
                }
                else
                {
                    QuestionField qf = new QuestionField();
                    qf.Top = r * qf.Height + (int)(Math.Floor((double)(r / 3))) * lineWidth;
                    qf.Left = qf.Width + (int)(Math.Floor((double)(55))) * lineWidth;
                    panel1.Controls.Add(qf);
                }
            }
            for (int i = 0; i < 7; i++)
            {
                Label L = new Label();
                L.Top = (int)(1.37 * i * L.Height + (int)(Math.Floor((double)(i / 3))) * lineWidth + 0.7);
                L.Left = 0;
                L.Text = names[i];
                L.Width = 1404;
                panel1.Controls.Add(L);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int ready = 0;

            foreach (var sf in panel1.Controls.OfType<QuestionField>())
            {
                ready += sf.Value;
            }
            if (ready > 2)
                MessageBox.Show("COVID-19 ALERT!");
            else
                MessageBox.Show("GOOD TO GO!");
        }
    }
}
