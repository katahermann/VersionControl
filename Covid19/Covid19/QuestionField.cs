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
            public QuestionField(string q)
            {
                this.Height = 30;
                this.Width = 150;
                this.BackColor = Color.White;
                Value = q;
            }

            private string _value;

            public string Value
            {
                get { return _value; }
                set
                {
                    _value = value;
                if (_value != "")
                    Text = _value;
                else
                    Text = "";
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

