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
            string[] names = {"Nem","Kor","Kerdes1", "Kerdes2", "Kerdes3", "Kerdes4", "Kerdes5", };
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
                L.Top = i * L.Height + (int)(Math.Floor((double)(i / 3))) * lineWidth;
                L.Left = L.Width + (int)(Math.Floor((double)(10))) * lineWidth;
                L.Text = names[i];
                panel1.Controls.Add(L);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ready = "";

            foreach (var sf in panel1.Controls.OfType<QuestionField>())
            {
                ready += sf.Value.ToString();
            }

        }
    }
}
