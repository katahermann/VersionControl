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
        }

        private void CreateQField()
        {
            int lineWidth = 5;
            string[] names = {"Nem","Kor","Kerdes1", "Kerdes2", "Kerdes3", "Kerdes4", "Kerdes5", };
            for (int r = 0; r < 7; r++)
            {
                    QuestionField qf = new QuestionField(names[r]);
                    qf.Top = r * qf.Height + (int)(Math.Floor((double)(r / 3))) * lineWidth;
                    qf.Left = qf.Width + (int)(Math.Floor((double)(r / 3))) * lineWidth;
                panel1.Controls.Add(qf);
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
