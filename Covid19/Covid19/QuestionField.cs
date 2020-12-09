using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19
{
    class QuestionField : Button
    {
            public QuestionField()
            {
                this.Height = 30;
                this.Width = 50;
                this.BackColor = Color.White;
                Value = 1;
                MouseDown += QuestionField_MouseDown;
            }

            private void QuestionField_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                    Value--;
                if (e.Button == MouseButtons.Right)
                    Value++;
            }

        private int _value;
            public int Value
            {
                get { return _value; }
                set
                {
                    _value = value;
                if (_value >= 1)
                {
                    _value = 0;
                    this.BackColor = Color.White;
                }
                else if (_value <= 0)
                {
                    _value = 1;
                    this.BackColor = Color.LightGreen;
                }
                    if (_value == 1)
                        Text = "Igen";
                    else
                        Text = "Nem";
                }
            }

        private bool _active;

            public bool Active
            {
                get { return _active; }
                set
                {
                    _active = value;
                    if (_active)
                        Font = new Font(FontFamily.GenericSansSerif, 12);
                    else
                        Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
                }
            }

            private void InitializeComponent()
            {
                this.SuspendLayout();
                this.ResumeLayout(false);
            }
        }
    }

